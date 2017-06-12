#include "mainwindow.h"
#include <QApplication>
#include <QImage>
#include <QLabel>
int main(int argc, char *argv[])
{
    QApplication::setApplicationName("Gear-con");
    QApplication::setOrganizationName("capstoneProject");

    //singleApplication 선언
    QApplication a(argc, argv);

    MainWindow w;
    w.setWindowFlags(Qt::WindowCloseButtonHint);
    w.setWindowTitle("Gear-con");
    w.setFixedSize(280,280);
    //w.setStyleSheet("background:rgb(255,255,204)");
    w.setWindowFlags(Qt::FramelessWindowHint);
    w.show();


    return a.exec();
}
