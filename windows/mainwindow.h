#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QKeyEvent>
#include "networkudp.h"

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
    int test();
    void keyPressEvent( QKeyEvent *e );

private:
    networkUDP *thread;
    Ui::MainWindow *ui;
};

#endif // MAINWINDOW_H
