#include <Windows.h>
#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "keyboardcontrol.h"
#include "mousecontrol.h"
#include "settingcontrol.h"
#include <mmdeviceapi.h>
#include <endpointvolume.h>
#include <Audioclient.h>
#include <QImage>
#include <QPixmap>
#include <QLabel>
#include <QMessageBox>
#include <QProcess>
#include <QStringList>
#include "udplibrary.h"
#include <QByteArray>

//http://ko11011.tistory.com/8 imgage 출력을 이하여 .

MainWindow::MainWindow(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::MainWindow)
 {

    ui->setupUi(this);
    ui->textEdit->setStyleSheet("background:rgb(255,255,255)");
    //statusBar()->setVisible( false );
    UDP= UdpLibrary::getInstance();
    QObject::connect(UDP,SIGNAL(sendToUser(QStringList)),this,SLOT(receiveMessage(QStringList)));
    QObject::connect(UDP,SIGNAL(connectState(bool)),this,SLOT(checkConnect(bool)));

}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::checkConnect(bool state){
    qDebug() << "CURRENT : " << state;
    if(state){
        //hide(); // background
        QMessageBox msg;
        msg.information(this, "connect", "connect success");
    } else{
        QMessageBox msg;
        msg.warning(this, "connect", "connect error : don't find any host"
                                     "\n\t please restart gearcon!");
        this->close();
    }

}

void MainWindow::receiveMessage(QStringList message){
    if(message.isEmpty()){
        qDebug() << returnType::error_get;
        //return returnType::error_get;
    }

    if(message[0] == "mouse"){
        qDebug() << "mouse";
        message.removeFirst();
        mouseControl m(message);
        //emit mouseEvent(message);
    }
    else if(message[0] == "ppt" || message[0] == "video" || message[0] == "pdf"){
        qDebug() << message[0];
        keyBoardControl k(message);
        //emit keboardEvent(message);
    }
    else if(message[0] == "setting"){
        qDebug() << "setting";
        message.removeFirst();
        settingControl s(message);
        //emit settingEvent(message);
    }
    else if(message[0] == "pc"){
         system("shutdown -s");
    }
    else if(message[0] == "connect"){
         if(message[1] == "shutdown"){
            show();
            ui->textEdit->setText("");
            //QApplication::quit();
         }
    }
}

/*int MainWindow::test(){
    qDebug("test start");
    while(UDP->udpSocket->hasPendingDatagrams()){
        qDebug() << UDP->udpSocket->receiveDatagram().data();
    }

    videoControl vi;

    vi.stToggle();
    return returnType::sussecc;
}*/

void MainWindow::keyPressEvent( QKeyEvent *e )
{
    qDebug("press");
    //`qDebug("press key = " + e->key());
 /*   if( e->key() == Qt::Key_1){
        videoControl a;

        //a.jmpBack();
        //a.closeExcute();
        //a.checkDisplay();
//        qDebug("click");
//        system("shutdown -s");
        /*QString processPath = "cmd.exe";
        QProcess *exitProcess;
        exitProcess = new QProcess(this);
        QStringList arguments;
        arguments << "shutdown -s";
        exitProcess->execute(processPath, arguments);
    }

    if( e->key() == Qt::Key_2){
       settingControl settings;
            settings.brightControl(false);
    }

    if( e->key() == Qt::Key_0){
        settingControl settings;
             settings.brightControl(true);
    }*/

    if( e->key() == Qt::Key_Escape ){
        this->close();
    }

/*
    if( e->key() == Qt::Key_I){
        videoControl a;
        a.pressLeftKey(0,-5);
    }
    if( e->key() == Qt::Key_K){
        videoControl a;
        a.pressLeftKey(0,5);
    }
    if( e->key() == Qt::Key_J){
        videoControl a;
        a.pressLeftKey(-5,0);
    }
    if( e->key() == Qt::Key_L){
        videoControl a;
        a.pressLeftKey(+5,0);
    }*/
}

void MainWindow::on_pushButton_clicked()
{

//    UDP->bindSocket(3456);
    UDP->init("222.108.245.162", 23272);
    UDP->bindSocket(3456);
    QByteArray token = ui->textEdit->toPlainText().toUtf8();
    char s[99] = "";
    sprintf(s, "%p", GetActiveWindow());
//    QString s;
//    int len = GetWindowTextLength(GetActiveWindow());
//    if (len > 0)
//    {
//        s.resize(len + 1);
//        len = GetWindowText(GetActiveWindow(), (LPWSTR)&s[0], s.size());
//        s.resize(len);
//     }
//    id = ;
    QString string (s);
    qDebug() << string.right(6);
    UDP->enroll(token,string.right(6).toUtf8());

//    connect(UDP->udpSocket,SIGNAL(readyRead()),this,SLOT(test()));
//    connect(UDP,UDP->set_listen_callback(),this,test());

}
