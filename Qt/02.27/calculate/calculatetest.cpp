#include "calculatetest.h"
#include "calculate.h"
#include "stackInList.h"
#include "stackInMassive.h"
#include <QtCore/QDebug>

void  CalculateTest::addNumberListTest()
{
    stackNamespace::StackInList stack = stackNamespace::StackInList();
    calculateNamespace::Calculate calculator = calculateNamespace::Calculate(stack);
    calculator.addNumber(2);
    QVERIFY(calculator.outputResult() == 2);
}

void  CalculateTest::addNumberMassiveTest()
{
    stackNamespace::StackInMassive stack = stackNamespace::StackInMassive();
    calculateNamespace::Calculate calculator = calculateNamespace::Calculate(stack);
    calculator.addNumber(2);
    QVERIFY(calculator.outputResult() == 2);
}

void CalculateTest::CalculateTwoNumbersTest()
{
    stackNamespace::StackInMassive stack = stackNamespace::StackInMassive();
    calculateNamespace::Calculate calculator = calculateNamespace::Calculate(stack);
    calculator.addNumber(2);
    calculator.addNumber(3);
    calculator.addSign('+');
    QVERIFY(calculator.outputResult() == 5);
}

void CalculateTest::CalculateSomeNumbersTest()
{
    stackNamespace::StackInList stack = stackNamespace::StackInList();
    calculateNamespace::Calculate calculator = calculateNamespace::Calculate(stack);
    calculator.addNumber(2);
    calculator.addNumber(3);
    calculator.addSign('+');
    calculator.addNumber(3);
    calculator.addSign('*');
    QVERIFY(calculator.outputResult() == 15);
}

QTEST_MAIN(CalculateTest)
