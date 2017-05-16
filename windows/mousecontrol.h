#ifndef mouseControl_H
#define mouseControl_H

class mouseControl
{
public:
    mouseControl();
    int setFocus(int , int );
    int getFoucus();
    int leftClick();
    int rightClick();
    int doubleClick();

private:
    int xCursorPosition();
    int yCursorPosition();
};

#endif // mouseControl_H
