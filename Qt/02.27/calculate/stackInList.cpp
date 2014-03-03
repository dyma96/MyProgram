#include "stackInList.h"

using namespace stackNameSpace;


/*Stack::Stack() {
}

*/
StackInList::StackInList() {
    this->head = new ListElement();
}

/*
StackInList::~StackInList() {
    head->deleteElement();
}
*/
void StackInList::push(int value) {
    ListElement *temp = new ListElement(value, head);
    head = temp;
}

int StackInList::pop() {
    int value = head->value();
    ListElement *temp = head;
    head = head->next();
    temp->deleteElement();
    return value;
}

StackInList::ListElement::ListElement() : myValue(0), myNext(nullptr) {
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

int StackInList::ListElement::value() {
    return myValue;
}

StackInList::ListElement *StackInList::ListElement::next() {
    return myNext;
}


