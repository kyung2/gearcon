#include "communicationtserver.h"
#include "mainwindow.h"

communicationtServer::communicationtServer()
{

}

communicationtServer::communicationtServer(QString ip)
{
    this->serverIP = ip;
}

int communicationtServer::execute(QString urls)
{
    // url form (//window//connect//checkAuth//?data="authString")
    /*QNetworkAccessManager * mgr = new QNetworkAccessManager();;
    connect(mgr,SIGNAL(finished(QNetworkReply*)),mgr,SLOT(deleteLater()));
    mgr->get(QNetworkRequest(QUrl(serverIP + url)));*/
    return returnType::sussecc;
}
