#pragma once

#include "stack.h"
#include "stackInList.h"

namespace calculateNamespace {
// Realize calculate: can add number, +, -, *, \, output result
class Calculate
{
public:
    Calculate();

    Calculate(stackNamespace::StackInList newStack);

    // add number to stack.
    void addNumber(int newNumber);

    // calculate 2 numbers with sign.
    void addSign(char sign);

    // return value in head in stack.
    int outputResult() const;

private:
    //calculate 2 numbers in stack with sign, push result.
    void calculateTwoNumbers(char sign);

    stackNamespace::StackInList stack;
};

}
