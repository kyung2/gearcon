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

int mouseControl::scroll(bool upDownToggle){

    INPUT    Input={0};
    Input.type      = INPUT_MOUSE;
    Input.mi.dwFlags  = MOUSEEVENTF_WHEEL;
    // wheel up
    Input.mi.mouseData = 120;
    if(upDownToggle){
        //wheel down
        Input.mi.mouseData = -120;
    }
    //wheel event
    ::SendInput(1,&Input,sizeof(INPUT));

    return returnType::sussecc;
}

int mouseControl::leftClick(){

    INPUT    Input={0};
    // left down
    Input.type      = INPUT_MOUSE;
    Input.mi.dwFlags  = MOUSEEVENTF_LEFTDOWN;
    ::SendInput(1,&Input,sizeof(INPUT));

    // left up
    ::ZeroMemory(&Input,sizeof(INPUT));
    Input.type      = INPUT_MOUSE;
    Input.mi.dwFlags  = MOUSEEVENTF_LEFTUP;
    ::SendInput(1,&Input,sizeof(INPUT));

    return returnType::sussecc;
}

int mouseControl::rightClick(){

    INPUT    Input={0};
    // left down
    Input.type      = INPUT_MOUSE;
    Input.mi.dwFlags  = MOUSEEVENTF_RIGHTDOWN;
    ::SendInput(1,&Input,sizeof(INPUT));

    // left up
    ::ZeroMemory(&Input,sizeof(INPUT));
    Input.type      = INPUT_MOUSE;
    Input.mi.dwFlags  = MOUSEEVENTF_RIGHTUP;
    ::SendInput(1,&Input,sizeof(INPUT));

    return returnType::sussecc;
}

int mouseControl::doubleClick(){

    leftClick();
    leftClick();

    return returnType::sussecc;
}
