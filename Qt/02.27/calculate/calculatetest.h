#pragma once

#include <QtTest/QtTest>

class CalculateTest: public QObject
{
    Q_OBJECT
private slots:
    void addNumberTest();
    void CalculateTwoNumbersTest();
    void CalculateSomeNumbersTest();
};

//#include "calculatetest.moc"
