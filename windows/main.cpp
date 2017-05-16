#include "mainwindow.h"
#include <QApplication>
#include <QImage>
#include <QLabel>
int main(int argc, char *argv[])
{
    QApplication::setApplicationName("Gear-con");
    QApplication::setOrganizationName("apstoneProject");

    //singleApplication 선언
    QApplication a(argc, argv);

    MainWindow w;
    w.setWindowFlags(Qt::WindowCloseButtonHint);
    w.setWindowTitle("hyunkyung_qt_title_test");
    w.setFixedSize(280,280);

    w.show();



    return a.exec();
}
