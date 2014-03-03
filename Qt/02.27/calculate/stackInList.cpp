#include "stackInList.h"
#include "stack.h"

using namespace stackNamespace;

StackInList::StackInList() {
    this->myHead = new ListElement();
}

StackInList::~StackInList() {
    if (myHead == nullptr)
        return;
    for (ListElement *temp = myHead->next(); temp != nullptr; temp = temp->next()) {
        myHead->deleteElement();
        myHead = temp;
    }
}

void StackInList::push(int value) {
    ListElement *temp = new ListElement(value, myHead);
    myHead = temp;
}

int StackInList::pop() {
    int value = myHead->value();
    ListElement *temp = myHead;
    myHead = myHead->next();
    temp->deleteElement();
    return value;
}

int StackInList::head() const {
    return myHead->value();
}



StackInList::ListElement::ListElement(int value, ListElement *next)
    : myValue(value), myNext(next) {
}

StackInList::ListElement::~ListElement() {
    delete this;
}

void StackInList::ListElement::deleteElement() {
    delete this;
}

int StackInList::ListElement::value() const {
    return myValue;
}

StackInList::ListElement *StackInList::ListElement::next() const {
    return myNext;
}


