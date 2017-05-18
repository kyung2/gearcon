#ifndef VIDEOCONTROL_H
#define VIDEOCONTROL_H

class videoControl
{
public:
    videoControl();
    int stToggle();
    int jmpNext();
    int jmpBack();
    int executeTimer();
    void pressLeftKey(int, int);
    void closeExcute();
    int checkDisplay();
    void getHandle();
private:

};

#endif // VIDEOCONTROL_H
