#include "videocontrol.h"
#include "mainwindow.h"
#include <QDebug>
#include <qt_windows.h>
#include <QDesktopWidget>
#include <mmdeviceapi.h>
#include <endpointvolume.h>
#include <QApplication>
#include <Audioclient.h>
#include <QThread>
#include <QProcess>

videoControl::videoControl()
{

}

int videoControl::stToggle()
{
    //qDebug("click start stop toggle button");

    return returnType::sussecc;
}

int videoControl::jmpNext()
{
    return returnType::sussecc;
}

int videoControl::jmpBack()
{
    
    return returnType::sussecc;
}

int videoControl::checkDisplay(){
    return returnType::sussecc;
}

int videoControl::executeTimer()
{
    const byte CTRLKey = 17;
    const byte SHIFTKey = 16;
    const byte ESCKey = 27;

    const int KEYUP = 0x0002;
    int Info=0;
    qDebug("click start stop toggle button");

    keybd_event(CTRLKey, 0, 0, Info);   // ALT key 다운
    keybd_event(SHIFTKey, 0, 0, Info);   // ALT key 다운
    keybd_event(ESCKey, 0, 0, Info);   // ALT key 다운
    keybd_event(ESCKey, 0, KEYUP, Info);  // ALT key 업
    keybd_event(SHIFTKey, 0, KEYUP, Info);  // ALT key 업
    keybd_event(CTRLKey, 0, KEYUP, Info);  // ALT key 업

    //SendMessage(hWnd,WM_LBUTTONDOWN,(WPARAM)mousepos.x,(LPARAM)mousepos.y);
    return returnType::sussecc;
}

void videoControl::closeExcute()
{
    const byte ESCKey = 27;
    const int KEYUP = 0x0002;
    int Info=0;
    keybd_event(ESCKey, 0, 0, Info);   // ALT key 다운
    keybd_event(ESCKey, 0, KEYUP, Info);  // ALT key 업
}

void videoControl::pressLeftKey(int moveX, int moveY)
{

    HWND hWnd;
    HWND myHWnd;
    myHWnd = GetActiveWindow();
    //hWnd = FindWindow(L"CalcFrame",NULL);
    //hWnd = FindWindow(NULL,L"Windows Media Player");
    //hWnd = (HWND)"000B0930";
    hWnd = GetFocus();
    char cName[255];
    GetWindowText(hWnd, (LPWSTR)cName, sizeof(255));
    qDebug(cName);
    if(hWnd == NULL)
        qDebug("handle is not found");
    else
        qDebug("ok");
   // keybd_event(ESCKey, 0, 0, Info);   // ALT key 다운
   // keybd_event(ESCKey, 0, KEYUP, Info);  // ALT key 업
   // SetActiveWindow(hWnd);
    ShowWindowAsync(hWnd, SW_SHOWNORMAL); // 윈도우에 포커스를 줘서 최상위로 만든다
    SetForegroundWindow(hWnd);

    //SendMessage(hWnd, WM_SETFOCUS, 0, 0);
    //SendMessage(hWnd,WM_LBUTTONDOWN,(WPARAM)mousepos.x,(LPARAM)mousepos.y);
    //SendMessage(hWnd,WM_LBUTTONUP,(WPARAM)mousepos.x,(LPARAM)mousepos.y);
    //QWidget *d = QApplication::desktop()->screen();
    //QMouseEvent MouseEvent(QEvent::MouseButtonPress, QCursor::pos(),Qt::LeftButton,Qt::LeftButton, Qt::NoModifier);
    //QApplication::sendEvent(d, &MouseEvent);
    //QApplication::sendEvent(d, &MouseEvent);
    //PostMessage(hWnd, WM_LBUTTONDOWN, MK_LBUTTON, MAKELPARAM(mousepos.x, mousepos.y));
    //PostMessage(hWnd, WM_LBUTTONUP, 0, MAKELPARAM(mousepos.x, mousepos.y));

    //PostMessage(hWnd, WM_KEYDOWN, VK_NUMPAD1, 0);
     getHandle();
    Sleep(1000);
     const byte ESCKey = 32;
     const int KEYUP = 0x0002;
     int Info=0;
     keybd_event(ESCKey, 0, 0, Info);   // ALT key 다운
     keybd_event(ESCKey, 0, KEYUP, Info);  // ALT key 업

}

void videoControl::getHandle(){
    HWND hWnd;
    HWND hWndForeground = ::GetForegroundWindow();
       if(hWndForeground != hWnd) return;

       DWORD Strange = ::GetWindowThreadProcessId(hWndForeground, NULL);
       DWORD My = ::GetWindowThreadProcessId(hWnd, NULL);
       if( !::AttachThreadInput(My, Strange, TRUE) )
       {
          return;
         }
       ::SetForegroundWindow(hWnd);
       ::BringWindowToTop(hWnd);

}
