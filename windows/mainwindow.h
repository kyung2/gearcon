#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QKeyEvent>
#include "networkudp.h"
#include "udplibrary.h"

enum returnType
{
    sussecc,
    error_get,
    error_set,
    error_click,
    error_doubleClick
};

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT


public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();
    void keyPressEvent( QKeyEvent *e );

public slots:
    int test();


private:
    networkUDP *thread;
    Ui::MainWindow *ui;
    UdpLibrary* UDP;
};

#endif // MAINWINDOW_H
