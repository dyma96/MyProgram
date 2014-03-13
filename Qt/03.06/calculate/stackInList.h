#pragma once

#include "stack.h"

namespace stackNamespace {
// Stack In List.
class StackInList: public Stack
{
public:
    StackInList();
    ~StackInList();

    // Add element value to begin stack.
    virtual void push(int value);

    // Delete first element in stack and return its value.
    virtual int pop();

    // return value in head.
    virtual int head() const;

private:
    // Element in List. Have value and pointer to next element.
    class ListElement {
    public:
        ListElement() { }
        ListElement(int value, ListElement *next);
        ~ListElement();

        // Return value this element.
        int value() const;

        // Return pointer to next element.
        ListElement *next() const;

    private:
        int myValue = 0;
        ListElement *myNext = nullptr;
    };

    ListElement *myHead = nullptr; // Element in StackInList.
};
}
