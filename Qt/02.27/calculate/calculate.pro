#-------------------------------------------------
#
# Project created by QtCreator 2014-03-03T12:53:20
#
#-------------------------------------------------

QT       += core
QT       += testlib
QT       -= gui

TARGET = calculate
CONFIG   += console
CONFIG   -= app_bundle
CONFIG += c++11

TEMPLATE = app


SOURCES += main.cpp \
    stackInList.cpp \
    calculate.cpp \
    calculatetest.cpp \
    stackInMassive.cpp

HEADERS += \
    stackInList.h \
    stack.h \
    calculate.h \
    calculatetest.h \
    stackInMassive.h

FORMS +=
