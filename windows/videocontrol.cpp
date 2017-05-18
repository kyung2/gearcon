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
    qDebug("sound");
    HRESULT hr;
    CoInitialize(NULL);
        IMMDeviceEnumerator *deviceEnumerator = NULL;
        hr = CoCreateInstance(__uuidof(MMDeviceEnumerator), NULL, CLSCTX_INPROC_SERVER, __uuidof(IMMDeviceEnumerator), (LPVOID *)&deviceEnumerator);
        IMMDevice *defaultDevice = NULL;

        hr = deviceEnumerator->GetDefaultAudioEndpoint(eRender, eConsole, &defaultDevice);
        deviceEnumerator->Release();
        deviceEnumerator = NULL;

        IAudioEndpointVolume *endpointVolume = NULL;
        hr = defaultDevice->Activate(__uuidof(IAudioEndpointVolume), CLSCTX_INPROC_SERVER, NULL, (LPVOID *)&endpointVolume);
        defaultDevice->Release();
        defaultDevice = NULL;

        // -------------------------
        float currentVolume = 0;

        hr = endpointVolume->GetMasterVolumeLevelScalar(&currentVolume);

        qDebug(QByteArray::number(currentVolume));

        currentVolume += 0.01; // 기어에서 / 감소 받아와서 적용

        hr = endpointVolume->SetMasterVolumeLevelScalar((float)currentVolume, NULL);
        endpointVolume->Release();

        CoUninitialize();
        return 0;
    
    return returnType::sussecc;
}

int videoControl::checkDisplay(){
    WORD  GammaArray[3][256];
    HDC   hGammaDC = GetDC(0);
    WORD  wBrightness;

    HDC h = hGammaDC;
    WORD r[3][256];

    GetDeviceGammaRamp(hGammaDC, GammaArray);

    GetDeviceGammaRamp(h, r);

    wBrightness = r[0][0];     // reduce the brightness
    for(int i = 0; i < 5; i++){
        wBrightness -= i * 8 ;
        qDebug("for");
        for (int ik = 0; ik < 256; ik++) {
            int iArrayValue = ik * (wBrightness + 128);
            if (iArrayValue > 0xffff) iArrayValue = 0xffff;
            GammaArray[0][ik] = (WORD)iArrayValue;
            GammaArray[1][ik] = (WORD)iArrayValue;
            GammaArray[2][ik] = (WORD)iArrayValue;
        }
        SetDeviceGammaRamp (hGammaDC, GammaArray);
        Sleep (1000);
    }


/*
    wBrightness = 128;    // set the brightness back to normal
    for (int ik = 0; ik < 256; ik++) {
        int iArrayValue = ik * (wBrightness + 128);
        if (iArrayValue > 0xffff) iArrayValue = 0xffff;
        GammaArray[0][ik] = (WORD)iArrayValue;
        GammaArray[1][ik] = (WORD)iArrayValue;
        GammaArray[2][ik] = (WORD)iArrayValue;
    }

    SetDeviceGammaRamp (hGammaDC, GammaArray);
    Sleep (3000);

    ReleaseDC(NULL, hGammaDC);*/

    SetDeviceGammaRamp (h, r);
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
