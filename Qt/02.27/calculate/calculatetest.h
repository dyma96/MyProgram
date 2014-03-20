#pragma once

#include <QtTest/QtTest>

class CalculateTest: public QObject
{
    Q_OBJECT
private slots:
    void addNumberListTest();
    void addNumberMassiveTest();
    void CalculateTwoNumbersTest();
    void CalculateSomeNumbersTest();
};

//#include "calculatetest.moc"
