#-------------------------------------------------
#
# Project created by QtCreator 2014-03-03T12:53:20
#
#-------------------------------------------------

QT       += core gui
QT       += testlib
QT       += webkitwidgets
QT       += widgets

TARGET = calculate
CONFIG   += console
CONFIG   -= app_bundle
CONFIG += c++11

TEMPLATE = app


SOURCES += main.cpp \
    stackInList.cpp \
    calculate.cpp \
    calculatetest.cpp \
    mainWindow.cpp

HEADERS += \
    stackInList.h \
    stack.h \
    calculate.h \
    calculatetest.h \
    mainWindow.h

FORMS += \
    mainWindow.ui
