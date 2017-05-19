#include "settingcontrol.h"
#include <Windows.h>
#include <mmdeviceapi.h>
#include <endpointvolume.h>
#include <Audioclient.h>


settingControl::settingControl()
{

}

int settingControl::soundControl(int upDownToggle){
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

        if(upDownToggle)
            currentVolume += 0.01; // 기어에서 / 감소 받아와서 적용
        else
            currentVolume -= 0.01;

        hr = endpointVolume->SetMasterVolumeLevelScalar((float)currentVolume, NULL);
        endpointVolume->Release();

        CoUninitialize();
        return 0;
}


int settingControl::brightControl(int upDownToggle){

    WORD  GammaArray[3][256];
    HDC   hGammaDC = GetDC(0);
    WORD  wBrightness;

    HDC h = hGammaDC;
    WORD r[3][256];

    GetDeviceGammaRamp(hGammaDC, GammaArray);

    GetDeviceGammaRamp(h, r);

    if(upDownToggle)
        wBrightness = 128;  // true = up
    else
        wBrightness = 68;
    for (int ik = 0; ik < 256; ik++) {
        int iArrayValue = ik * (wBrightness + 128);
        if (iArrayValue > 0xffff) iArrayValue = 0xffff;
        GammaArray[0][ik] = (WORD)iArrayValue;
        GammaArray[1][ik] = (WORD)iArrayValue;
        GammaArray[2][ik] = (WORD)iArrayValue;
    }

    SetDeviceGammaRamp (hGammaDC, GammaArray);

}
