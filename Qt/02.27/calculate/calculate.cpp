#include "calculate.h"
using namespace calculateNamespace;

Calculate::Calculate(StackInList newStack): stack(newStack){
}

// add number to stack.
void Calculate::addNumber(int newNumber) {
    stack.push(newNumber);
}

// calculate 2 numbers with sign.
void Calculate::addSign(char sign) {
    calculateTwoNumbers(sign);
}

// return value in head in stack.
int Calculate::outputResult() const {
//    stack.Print();
    return stack.head();
}

//calculate 2 numbers in stack with sign, push result.
void Calculate::calculateTwoNumbers(char sign) {
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


