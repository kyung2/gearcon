#include "keyboradcontrol.h"

keyBoardControl::keyBoardControl()
{

}


// use ppt and video
int keyBoardControl::next(){
    pressKey = 39; // ->
    keyPress();
}

// use ppt and video
int keyBoardControl::previous(){
    pressKey = 37; // <-
    keyPress();
}


int keyBoardControl::PPTstart(){
    pressKey = 116; // F5
    keyPress();
}


int keyBoardControl::videoStartStopToggle(){
    pressKey = 32; // spacebar
    keyPress();
}


int keyBoardControl::pdfNext(){
    pressKey = 27;//F5
    keyPress();
}

int keyBoardControl::pdfPrevious(){
    pressKey = 27;//F5
    keyPress();
}

int keyBoardControl::pdfscroll(){
    pressKey = 27;//F5
    keyPress();
}

void keyBoardControl::keyPress(){
    keybd_event(pressKey, 0, 0, Info);
    keybd_event(pressKey, 0, KEYUP, Info);
}
