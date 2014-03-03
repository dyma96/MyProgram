#pragma once

#include "stack.h"

namespace stackNameSpace {
class StackInList: public Stack
{
public:
    StackInList();
    ~StackInList();
    virtual void push(int value);
    virtual int pop();
private:
    class ListElement {
    public:
        ListElement();
        ListElement(int value, ListElement *next);
        ~ListElement();
    //    void addElement(int value);
        void deleteElement();
        int value();
        ListElement *next();
    private:
        int myValue = 0;
        ListElement *myNext;
    };

    ListElement *head;
};
}
