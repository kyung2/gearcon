#ifndef SETTINGCONTROL_H
#define SETTINGCONTROL_H
#include <Windows.h>
#include <QStringList>


class settingControl
{
public:
    settingControl(QStringList message);
    int soundControl(bool upDownToggle);
    int brightControl(bool upDownToggle);

private:
    QStringList sendMessage;
};

#endif // SETTINGCONTROL_H
