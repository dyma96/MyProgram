#pragma once

namespace stackNamespace {
// Interface stack.
class Stack {
public:
    virtual ~Stack() { }

    // Add element to head stack with value value.
    virtual void push(int const value) = 0;

    // Delete first element in stack and return value.
    virtual int pop() = 0;

    // return value in head.
    virtual int head() const = 0;
};
}
