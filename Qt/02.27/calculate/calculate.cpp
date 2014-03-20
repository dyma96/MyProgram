#include "calculate.h"
#include "stackInList.h"
using namespace calculateNamespace;
using namespace stackNamespace;


/*Calculate::Calculate()
    : stack(new StackInList())
{ }
*/
Calculate::Calculate(Stack &newStack): stack(newStack)
{ }

// add number to stack.
void Calculate::addNumber(int newNumber)
{
    stack.push(newNumber);
}

// calculate 2 numbers with sign.
void Calculate::addSign(char sign)
{
    calculateTwoNumbers(sign);
}

// return value in head in stack.
int Calculate::outputResult() const
{
    return stack.head();
}

//calculate 2 numbers in stack with sign, push result.
void Calculate::calculateTwoNumbers(char sign)
{
    int value1 = stack.pop();
    int value2 = stack.pop();
    int valueResult = 0;
    if (sign == '+')
        valueResult = value1 + value2;
    else if (sign == '-')
        valueResult = value2 - value1;
    else if (sign == '*')
        valueResult = value1 * value2;
    else if (sign == '/')
        valueResult = value2 / value1;
    stack.push(valueResult);
}


