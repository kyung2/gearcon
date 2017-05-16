#ifndef COMMUNICATIONTSERVER_H
#define COMMUNICATIONTSERVER_H
#include <QString>

class communicationtServer
{
public:
    communicationtServer();
    communicationtServer(QString ip);
    int execute(QString urls);

private:
    QString serverIP = "http://127.0.0.1"; // local server
};

#endif // COMMUNICATAIONTSERVER_H
