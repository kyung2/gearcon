#include "settingcontrol.h"
#include <Windows.h>
#include <mmdeviceapi.h>
#include <endpointvolume.h>
#include <Audioclient.h>
#include <QDebug>
#include "PhysicalMonitorEnumerationAPI.h"
#include "HighLevelMonitorConfigurationAPI.h"

settingControl::settingControl(QStringList message)
{
    this->sendMessage = message;
    if(sendMessage[0] == "sound"){
        if(sendMessage[1] == "up")
           soundControl(true);
        else if(sendMessage[1] == "down")
           soundControl(false);
    }
    else if(sendMessage[0] == "brightness"){
        if(sendMessage[1] == "up")
            brightControl(true);
        else if(sendMessage[1] == "down")
            brightControl(false);
    }
}

int settingControl::soundControl(bool upDownToggle){
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
\
        if(upDownToggle)
            currentVolume += 0.01; // increse
        else
            currentVolume -= 0.01;

        hr = endpointVolume->SetMasterVolumeLevelScalar((float)currentVolume, NULL);
        endpointVolume->Release();

        CoUninitialize();
        return 0;
}


int settingControl::brightControl(bool upDownToggle){



/*    HMONITOR hMonitor = NULL;
        DWORD cPhysicalMonitors = 1;
        LPPHYSICAL_MONITOR pPhysicalMonitors;

        HWND hWnd = GetDesktopWindow();

        // Get the monitor handle.
        hMonitor = MonitorFromWindow(hWnd, MONITOR_DEFAULTTOPRIMARY);

        // Get the number of physical monitors.
        BOOL bSuccess = GetNumberOfPhysicalMonitorsFromHMONITOR(hMonitor, &cPhysicalMonitors);

        if (bSuccess)
        {
            // Allocate the array of PHYSICAL_MONITOR structures.
            pPhysicalMonitors = (LPPHYSICAL_MONITOR)malloc(cPhysicalMonitors* sizeof(PHYSICAL_MONITOR));

            if (pPhysicalMonitors != NULL)
            {
                // Get the array.
                bSuccess = GetPhysicalMonitorsFromHMONITOR( hMonitor, cPhysicalMonitors, pPhysicalMonitors);
                if (bSuccess == FALSE)
                {

                    qDebug("GetPhysicalMonitorsFromHMONITOR");
                }
                // Get physical monitor handle.
                HANDLE hPhysicalMonitor = pPhysicalMonitors[0].hPhysicalMonitor;
                DWORD pdwMonitorCapabilities = 0;
                DWORD pdwSupportedColorTemperatures = 0;
                bSuccess = GetMonitorCapabilities(hPhysicalMonitor, &pdwMonitorCapabilities, &pdwSupportedColorTemperatures);
                if (bSuccess == FALSE)
                {

                    DWORD a = GetLastError();

                    qDebug(QByteArray::number((WORD)a));
                    qDebug("GetMonitorCapabilities");
                }

                DWORD pdwMinimumBrightness = 0;
                DWORD pdwCurrentBrightness = 0;
                DWORD pdwMaximumBrightness = 0;
                bSuccess = GetMonitorBrightness(hPhysicalMonitor, &pdwMinimumBrightness, &pdwCurrentBrightness, &pdwMaximumBrightness);
                if (bSuccess == FALSE)
                {

                    DWORD a = GetLastError();

                    qDebug(QByteArray::number((WORD)a));
                    qDebug("GetMonitorBrightness");
                }

                qDebug(QByteArray::number(bSuccess));

                qDebug(QByteArray::number((WORD)pdwMinimumBrightness));
                qDebug(QByteArray::number((WORD)pdwCurrentBrightness));
                qDebug(QByteArray::number((WORD)pdwMaximumBrightness));
                // Close the monitor handles.
                bSuccess = DestroyPhysicalMonitors(cPhysicalMonitors, pPhysicalMonitors);

                // Free the array.
                free(pPhysicalMonitors);
            }
        }


    //setMonitorBrightness(pmh,(DWORD)pdwCurrentBrightness);
*/

    WORD  GammaArray[3][256];
    HDC   hGammaDC = GetDC(NULL);
    WORD  wBrightness;

    GetDeviceGammaRamp(hGammaDC, GammaArray);

    wBrightness = GammaArray[1][1] - 128;

   if(upDownToggle){
        if(wBrightness < 128)
            wBrightness += 16;  // true = up
    }
    else{
        if(wBrightness > 0)
            wBrightness -= 16;    // reduce the brightness
    }

    for (int ik = 0; ik < 256; ik++) {
        int iArrayValue = ik * (wBrightness + 128);
        if (iArrayValue > 0xffff) iArrayValue = 0xffff;
        GammaArray[0][ik] = (WORD)iArrayValue;
        GammaArray[1][ik] = (WORD)iArrayValue;
        GammaArray[2][ik] = (WORD)iArrayValue;
    }

    SetDeviceGammaRamp (hGammaDC, GammaArray);

    return 0;
}
