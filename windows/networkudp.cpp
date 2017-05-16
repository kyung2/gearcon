#include "networkudp.h"
#include <QObject>

networkUDP::networkUDP( QObject * parent ) :QThread(parent)
{
    udpSocketSend = new QUdpSocket(this);
    udpSocketGet  = new QUdpSocket(this);
    start();
}

int networkUDP::sendPacket(){
    //bcast = new QHostAddress(QHostAddress::LocalHost,7755); // localhost
     udpSocketSend->connectToHost(QHostAddress::LocalHost,65001);

     QByteArray *datagram = makeNewDatagram(); // data from external function
     udpSocketSend->write(*datagram);
     return 0;
}

void networkUDP::create(){
}

void networkUDP::run(){
    qDebug("thread start");
    udpSocketGet->bind(QHostAddress::Any,4000);

    connect(udpSocketGet,SIGNAL(readyRead()),this,SLOT(readPendingDatagrams()));
    exec();
}
int networkUDP::getPacket(){
   // host  = new QHostAddress(QHostAddress::Any);

//    udpSocketGet->bind(*host, udpSocketSend->localPort());

    return 0;
}

void networkUDP::readPendingDatagrams(){
    qDebug("success");
    while (udpSocketGet->hasPendingDatagrams()) {
        QNetworkDatagram datagram = udpSocketGet->receiveDatagram();
        processTheDatagram(datagram);
    }
}

QByteArray* networkUDP::makeNewDatagram(){
    QByteArray packet = "packet";
    return &packet;
}

int networkUDP::processTheDatagram(QNetworkDatagram datagram){
    qDebug(datagram.data());
    return 0;
}
