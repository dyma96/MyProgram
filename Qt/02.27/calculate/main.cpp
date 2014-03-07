#include <QCoreApplication>
#include <QtCore/QtDebug>
#include <iostream>

#include "stack.h"
#include "stackInList.h"
#include "calculate.h"

using namespace std;
using namespace calculateNamespace;
using namespace stackNamespace;

/*
int main()
{
    Calculate calculate = Calculate(StackInList());
    while (true)
    {
        qDebug() << "0 - exit\n1 - add number\n2 - add sign\n3 - calculate";
        int whatDo = 0;
        cin >> whatDo;
        if (whatDo == 0)
            break;
        else if (whatDo == 1)
        {
            qDebug() << "add number";
            int newNum = 0;
            cin >> newNum;
            calculate.addNumber(newNum);
        }
        else if (whatDo == 2)
        {
            qDebug() << "add sign";
            char newSign = 0;
            cin >> newSign;
            calculate.addSign(newSign);
        }
        else if (whatDo == 3)
        {
            qDebug() << "result:" << calculate.outputResult();
        }

    }
    return 0;
}
*/
