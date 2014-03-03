#pragma once

namespace stackNameSpace {
class Stack {
public:
    Stack();
    virtual ~Stack();

    // Add element to head stack with value value.
    virtual void push(int value);

    // Delete first element in stack and return value.
    virtual int pop();
};
}
