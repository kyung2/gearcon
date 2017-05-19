#ifndef PPTCONTROL_H
#define PPTCONTROL_H


class keyBoardControl
{
public:
    keyBoardControl();

    int PPTstart();

    int videoStart();

    int next();
    int previous();

    int pdfNext();
    int pdfPrevious();
    int pdfscroll();

private:
    const byte pressKey;
    const int KEYUP = 0x0002;
    int Info=0;
};

#endif // PPTCONTROL_H
