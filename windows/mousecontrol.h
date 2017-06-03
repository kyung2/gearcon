#ifndef mouseControl_H
#define mouseControl_H
#include <QStringList>

class mouseControl
{
public:
    mouseControl(QStringList message);
    int setFocus(int , int );
    int scroll(bool upDownToggle);
    int leftClick();
    int rightClick();
    int doubleClick();

private:
    int xCursorPosition();
    int yCursorPosition();
    QStringList sendMessage;
};

#endif // mouseControl_H
