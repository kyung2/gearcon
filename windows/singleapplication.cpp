/*
 네트워크를 이용하여 컴퓨터 내에서 같은 이름의 process가 작동되지 않게 하여 singleton을 구현.
 open source 를 이용하여 구현
 qt에서 제공하는 기본 싱글 어플리케이션은 현재 존재하지 않고 라이브러리를 받아 개인적으로 빌드하여 사용할 수 있는데
 방법이 복잡하고 구현하기 어려워 open source 활용
*/


#include "singleapplication.h"
#include <QSharedMemory>
#include <QLocalSocket>
#include <QLocalServer>
#include <QMutex>
#include <cstdlib>

#ifdef Q_OS_UNIX
    #include <signal.h>
    #include <unistd.h>
#endif

class SingleApplicationPrivate {
public:
    SingleApplicationPrivate(SingleApplication *q_ptr) : q_ptr(q_ptr) { }

    void startServer(QString &serverName)
    {
        // Start a QLocalServer to listen for connections

        server = new QLocalServer();
        server->removeServer(serverName);
        server->listen(serverName);
        QObject::connect(server, SIGNAL(newConnection()), q_ptr, SLOT(slotConnectionEstablished()));
    }

#ifdef Q_OS_UNIX
    void crashHandler()
    {
        // This guarantees the program will work even with multiple
        // instances of SingleApplication in different threads
        // Which in my opinion is idiotic, but lets handle that too
        {
            sharedMemMutex.lock();
            sharedMem.append(memory);
            sharedMemMutex.unlock();
        }
        // Handle any further termination signals to ensure the
        // QSharedMemory block is deleted even if the process crashes
        signal(SIGSEGV, SingleApplicationPrivate::terminate);
        signal(SIGABRT, SingleApplicationPrivate::terminate);
        signal(SIGFPE, SingleApplicationPrivate::terminate);
        signal(SIGILL, SingleApplicationPrivate::terminate);
        signal(SIGINT, SingleApplicationPrivate::terminate);
        signal(SIGTERM, SingleApplicationPrivate::terminate);
    }

    static void terminate(int signum)
    {
        while( ! sharedMem.empty() ) {
            delete sharedMem.back();
            sharedMem.pop_back();
        }
        ::exit(128 + signum);
    }

    static QList<QSharedMemory*> sharedMem;
    static QMutex sharedMemMutex;
#endif

    QSharedMemory *memory;
    SingleApplication *q_ptr;
    QLocalServer  *server;
    QLocalSocket  *socket;
};

#ifdef Q_OS_UNIX
    QList<QSharedMemory*> SingleApplicationPrivate::sharedMem;
    QMutex SingleApplicationPrivate::sharedMemMutex;
#endif

/**
 * @brief Constructor. Checks and fires up LocalServer or closes the program
 * if another instance already exists
 * @param argc
 * @param argv
 */
SingleApplication::SingleApplication(int &argc, char *argv[])
    : QAPPLICATION_CLASS(argc, argv), d_ptr(new SingleApplicationPrivate(this))
{
    QString serverName = QAPPLICATION_CLASS::organizationName() + QAPPLICATION_CLASS::applicationName();
    serverName.replace(QRegExp("[^\\w\\-. ]"), "");

    // Garantee thread safe behaviour with a shared memory block
    d_ptr->memory = new QSharedMemory(serverName);

    // Create a shared memory block with a minimum size of 1 byte
    if( d_ptr->memory->create(1, QSharedMemory::ReadOnly) )
    {
#ifdef Q_OS_UNIX
        // Handle any further termination signals to ensure the
        // QSharedMemory block is deleted even if the process crashes
        d_ptr->crashHandler();
#endif
        // Successful creation means that no main process exists
        // So we start a Local Server to listen for connections
        d_ptr->startServer(serverName);
    } else {
        // Connect to the Local Server of the main process to notify it
        // that a new process had been started
        d_ptr->socket = new QLocalSocket();
        d_ptr->socket->connectToServer(serverName);

        // Even though a shared memory block exists, the original application might have crashed
        // So only after a successful connection is the second instance terminated
        if( d_ptr->socket->waitForConnected(100) )
        {
            ::exit(EXIT_SUCCESS); // Terminate the program using STDLib's exit function
        } else {
            delete d_ptr->memory;
            ::exit(EXIT_SUCCESS);
        }
    }
}

/**
 * @brief Destructor
 */
SingleApplication::~SingleApplication()
{
    delete d_ptr->memory;
    d_ptr->server->close();
}

/**
 * @brief Executed when the showUp command is sent to LocalServer
 */


void SingleApplication::slotConnectionEstablished()
{
    QLocalSocket *socket = d_ptr->server->nextPendingConnection();
    socket->close();
    delete socket;
    emit showUp();
}
