#-------------------------------------------------
#
# Project created by QtCreator 2014-03-27T11:54:12
#
#-------------------------------------------------

QT       += core gui widgets

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = 1Gun
TEMPLATE = app


SOURCES += main.cpp\
        mainWindow.cpp \
    ovalGun.cpp \
    myGraphicsView.cpp

HEADERS  += mainWindow.h \
    ovalGun.h \
    myGraphicsView.h

FORMS    += mainWindow.ui
