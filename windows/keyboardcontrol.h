#ifndef PPTCONTROL_H
#define PPTCONTROL_H
#include <Windows.h>
#include <QStringList>


class keyBoardControl
{
public:
    keyBoardControl(QStringList message);

    int PPTstart();

    int videoStartStopToggle();

    int next();
    int previous();

    int pdfNext();
    int pdfPrevious();

    void keyPress();

private:
    byte pressKey = 0;
    const int KEYUP = 0x0002;
    int Info=0;
    QStringList sendMessage;
};

#endif // PPTCONTROL_H
