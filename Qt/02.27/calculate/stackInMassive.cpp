#include "stackInMassive.h"
#include "stack.h"
using namespace stackNamespace;

StackInMassive::StackInMassive() : length(0), mas(new int[100])
{
//    mas = new int[100];
//    length = 0;
}

StackInMassive::~StackInMassive()
{
    delete mas;
}

// Add element value to begin stack.
void StackInMassive::push(int value)
{
    mas[length] = value;
    length++;
}

// Delete first element in stack and return its value.
int StackInMassive::pop()
{
    if (length <= 0)
        return -1;
    length--;
    return mas[length];
}

// return value in head.
int StackInMassive::head() const
{
    if (length <= 0)
        return -1;
    return mas[length - 1];
}

