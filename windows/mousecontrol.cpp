#include "mouseControl.h"
#include "mainwindow.h"
#include <Windows.h>

mouseControl::mouseControl()
{

}

int mouseControl::setFocus(int moveX, int moveY){
    POINT mousepos;
    GetCursorPos(&mousepos);
    int i;
    for(i = 0; i<5; i++){
        GetCursorPos(&mousepos);
        SetCursorPos(mousepos.x+moveX,mousepos.y+moveY);
        QThread::msleep(10);
    }
    GetCursorPos(&mousepos);
    return returnType::sussecc;
}

int mouseControl::getFoucus(){
    return returnType::sussecc;
}

int mouseControl::leftClick(){
    return returnType::sussecc;
}

int mouseControl::rightClick(){
    return returnType::sussecc;
}

int mouseControl::doubleClick(){
    return returnType::sussecc;
}
