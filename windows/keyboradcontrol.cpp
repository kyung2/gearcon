#include "keyboradcontrol.h"

keyBoardControl::keyBoardControl()
{
}


void keyBoardControl::keyPress(){
    keybd_event(pressKey, 0, 0, Info);
    keybd_event(pressKey, 0, KEYUP, Info);
}

// use ppt and video
int keyBoardControl::next(){
    pressKey = 39; // right arrow
    keyPress();
    return 0;
}

// use ppt and video
int keyBoardControl::previous(){
    pressKey = 37; // left arrow
    keyPress();
    return 0;
}


int keyBoardControl::PPTstart(){
    pressKey = 116; // F5
    keyPress();
    return 0;
}


int keyBoardControl::videoStartStopToggle(){
    pressKey = 32; // spacebar
    keyPress();
    return 0;
}


int keyBoardControl::pdfNext(){
    pressKey = 40; // down arrow
    keyPress();
    return 0;
}

int keyBoardControl::pdfPrevious(){
    pressKey = 38; // up arrow
    keyPress();
    return 0;
}
