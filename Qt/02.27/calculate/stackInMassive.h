#pragma once
#include "stack.h"

namespace stackNamespace {
// Stack in massive.
class StackInMassive : public Stack
{
public:
    StackInMassive();
    ~StackInMassive();

    // Add element value to begin stack.
    void push(int value) override;

    // Delete first element in stack and return its value.
    int pop() override;

    // return value in head.
    int head() const override;

private:
    int *mas;
    int length;
};
}
