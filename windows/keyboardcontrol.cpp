#include "keyboardcontrol.h"
#include "mousecontrol.h"

keyBoardControl::keyBoardControl(QStringList message)
{
    this->sendMessage = message;
    if(sendMessage[0] == "ppt" || sendMessage[0] == "video"){
        if(sendMessage[1] == "next")
            next();
        else if(sendMessage[1] == "pre")
            previous();
        else if(sendMessage[0] == "ppt" && sendMessage[1] == "start")
            PPTstart();
        else if(sendMessage[0] == "ppt" && sendMessage[1] == "startHere")
            PPTstartHere();
        else if(sendMessage[1] == "speed"){
            if(sendMessage[2] == "up")
                videoSpeedUp();
            else if(sendMessage[2] == "down")
                videoSpeedDown();
        }
        else if(sendMessage[1] == "start" || sendMessage[1] == "stop")
            videoStartStopToggle();
    }
    else if(sendMessage[0] == "pdf"){
        if(sendMessage[1] == "next")
            pdfNext();
        else if(sendMessage[1] == "pre")
            pdfPrevious();
        if(sendMessage[1] == "scroll"){
            sendMessage.removeFirst();
            mouseControl m(sendMessage);
         }
    }
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

    pressKey = 16; // shift
    keyPress();

    pressKey = 116; // F5
    keyPress();
    return 0;
}
int keyBoardControl::PPTstartHere(){
    pressKey = 116; // F5
    keyPress();
    return 0;
}

void keyBoardControl::videoSpeedUp(){
    pressKey = 67; // c
    keyPress();
}

void keyBoardControl::videoSpeedDown(){
    pressKey = 88; // c
    keyPress();
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
