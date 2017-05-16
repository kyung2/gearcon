#ifndef NETWORKUDP_H
#define NETWORKUDP_H
#include <QUdpSocket>
#include <QHostAddress>
#include <QByteArray>
#include <QNetworkDatagram>
#include <QThread>


class networkUDP : public QThread
{
    Q_OBJECT

public:
    explicit networkUDP( QObject * parent=0 );
    int sendPacket();
    int getPacket();
    QByteArray* makeNewDatagram();
    void create();
    //    ~networkUDP();
    int processTheDatagram(QNetworkDatagram );

protected:
    void run();

public slots:
    void readPendingDatagrams();

private:
    QUdpSocket * udpSocketSend;
    QUdpSocket * udpSocketGet;
};

#endif // NETWORKUDP_H
