#include "stackInList.h"
#include "stack.h"

using namespace stackNamespace;

StackInList::StackInList()
{
    this->myHead = new ListElement();
}

StackInList::~StackInList()
{
    if (myHead == nullptr)
        return;
    for (ListElement *temp = myHead->next(); temp != nullptr; temp = temp->next()) {
        delete myHead;
        myHead = temp;
    }
}

void StackInList::push(int value)
{
    ListElement *temp = new ListElement(value, myHead);
    myHead = temp;
}

int StackInList::pop()
{
    if (myHead == nullptr)
        return -1;
    int value = myHead->value();
    ListElement *temp = myHead;
    myHead = myHead->next();
    delete temp;
    return value;
}

int StackInList::head() const
{
    return myHead->value();
}



StackInList::ListElement::ListElement(int value, ListElement *next)
    : myValue(value), myNext(next)
{ }

StackInList::ListElement::~ListElement()
{ }


int StackInList::ListElement::value() const
{
    return myValue;
}

StackInList::ListElement *StackInList::ListElement::next() const
{
    return myNext;
}


