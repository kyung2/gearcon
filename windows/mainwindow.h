#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QKeyEvent>
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

signals:
    //void mouseEvent (QStringList message);
    //void keboardEvent (QStringList message);
    //void settingEvent (QStringList message);

private slots:
    void on_pushButton_clicked();
    void receiveMessage(QStringList);

private:
    Ui::MainWindow *ui;
    UdpLibrary* UDP;
};

#endif // MAINWINDOW_H
