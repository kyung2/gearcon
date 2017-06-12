#-------------------------------------------------
#
# Project created by QtCreator 2017-04-16T23:41:25
#
#-------------------------------------------------

QT       += core gui network

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = Gear-con
TEMPLATE = app

# The following define makes your compiler emit warnings if you use
# any feature of Qt which as been marked as deprecated (the exact warnings
# depend on your compiler). Please consult the documentation of the
# deprecated API in order to know how to port your code away from it.
DEFINES += QT_DEPRECATED_WARNINGS

# You can also make your code fail to compile if you use deprecated APIs.
# In order to do so, uncomment the following line.
# You can also select to disable deprecated APIs only up to a certain version of Qt.
#DEFINES += QT_DISABLE_DEPRECATED_BEFORE=0x060000    # disables all the APIs deprecated before Qt 6.0.0


SOURCES += main.cpp\
        mainwindow.cpp \
    communicationtserver.cpp \
    mousecontrol.cpp \
    singleapplication.cpp \
    videocontrol.cpp \
    networkudp.cpp \
    settingcontrol.cpp \
    keyboardcontrol.cpp

HEADERS  += mainwindow.h \
    communicationtserver.h \
    mousecontrol.h \
    singleapplication.h \
    videocontrol.h \
    networkudp.h \
    settingcontrol.h \
    keyboardcontrol.h

FORMS    += mainwindow.ui

LIBS += -luser32
LIBS += -lGdi32
LIBS += -lole32
LIBS += -lDxva2

RESOURCES += \
    img.qrc

win32:CONFIG(release, debug|release): LIBS += -L$$PWD/../../udpLibrary/Windows/build-udpLibrary-Desktop_Qt_5_8_0_MSVC2015_64bit-Debug/release/ -ludpLibrary
else:win32:CONFIG(debug, debug|release): LIBS += -L$$PWD/../../udpLibrary/Windows/build-udpLibrary-Desktop_Qt_5_8_0_MSVC2015_64bit-Debug/debug/ -ludpLibrary
else:unix: LIBS += -L$$PWD/../../udpLibrary/Windows/build-udpLibrary-Desktop_Qt_5_8_0_MSVC2015_64bit-Debug/ -ludpLibrary

INCLUDEPATH += $$PWD/../../udpLibrary/Windows/udpLibrary
DEPENDPATH += $$PWD/../../udpLibrary/Windows/udpLibrary

win32-g++:CONFIG(release, debug|release): PRE_TARGETDEPS += $$PWD/../../udpLibrary/Windows/build-udpLibrary-Desktop_Qt_5_8_0_MSVC2015_64bit-Debug/release/libudpLibrary.a
else:win32-g++:CONFIG(debug, debug|release): PRE_TARGETDEPS += $$PWD/../../udpLibrary/Windows/build-udpLibrary-Desktop_Qt_5_8_0_MSVC2015_64bit-Debug/debug/libudpLibrary.a
else:win32:!win32-g++:CONFIG(release, debug|release): PRE_TARGETDEPS += $$PWD/../../udpLibrary/Windows/build-udpLibrary-Desktop_Qt_5_8_0_MSVC2015_64bit-Debug/release/udpLibrary.lib
else:win32:!win32-g++:CONFIG(debug, debug|release): PRE_TARGETDEPS += $$PWD/../../udpLibrary/Windows/build-udpLibrary-Desktop_Qt_5_8_0_MSVC2015_64bit-Debug/debug/udpLibrary.lib
else:unix: PRE_TARGETDEPS += $$PWD/../../udpLibrary/Windows/build-udpLibrary-Desktop_Qt_5_8_0_MSVC2015_64bit-Debug/libudpLibrary.a
