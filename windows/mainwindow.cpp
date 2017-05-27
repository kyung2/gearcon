#include <Windows.h>
#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "videocontrol.h"
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
#include "udplibrary.h"

#include "videocontrol.h"

//http://ko11011.tistory.com/8 imgage 출력을 이하여 .

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    statusBar()->setVisible( false );
    thread = new networkUDP(this);
    thread->start();
    test();
    UdpLibrary UDP;
    UDP.enroll();
}

MainWindow::~MainWindow()
{
    thread->exit();
    delete ui;
}


int MainWindow::test(){
    qDebug("test start");

    videoControl vi;

    vi.stToggle();
    return returnType::sussecc;
}

void MainWindow::keyPressEvent( QKeyEvent *e )
{
    qDebug("press");
    //`qDebug("press key = " + e->key());
    if( e->key() == Qt::Key_1){
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
        exitProcess->execute(processPath, arguments);*/
    }

    if( e->key() == Qt::Key_2){
       settingControl settings;
            settings.brightControl(false);
    }

    if( e->key() == Qt::Key_0){
        settingControl settings;
             settings.brightControl(true);
    }

    if( e->key() == Qt::Key_Escape ){
        this->close();
    }

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
    }
}
