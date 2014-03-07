#include "calculatetest.h"
#include "calculate.h"
#include <QtCore/QDebug>

void  CalculateTest::addNumberTest()
{
    calculateNamespace::Calculate calculator = calculateNamespace::Calculate();
    calculator.addNumber(2);
    QVERIFY(calculator.outputResult() == 2);
}
void CalculateTest::CalculateTwoNumbersTest()
{
    calculateNamespace::Calculate calculator = calculateNamespace::Calculate();
    calculator.addNumber(2);
    calculator.addNumber(3);
    calculator.addSign('+');
    QVERIFY(calculator.outputResult() == 5);
}

void CalculateTest::CalculateSomeNumbersTest()
{
    calculateNamespace::Calculate calculator = calculateNamespace::Calculate();
    calculator.addNumber(2);
    calculator.addNumber(3);
    calculator.addSign('+');
    calculator.addNumber(3);
    calculator.addSign('*');
    QVERIFY(calculator.outputResult() == 15);
}

QTEST_MAIN(CalculateTest)
