#pragma once

typedef int ElementType;
struct ListElement;
typedef ListElement *Position;
struct List;

// �������� ������.
List *createList(int number);

// ���������� �������� value ����� position.
void addElement(List *list, ElementType value, Position position);

// ���������� �������� value � ������ list.
void addElementToHead(List *list, ElementType value);

// �������� �������� position � list.
void deleteElement(List *list, Position position);

// �������� ����� list.
void deleteList(List *list);

// ���������� ������� ������� value � list.
Position positionOfElement(List *list, ElementType value);

// ���������� head � list.
ListElement *head(List *list);

// ���������� next � element.
ListElement *next(ListElement *element);

// ���������� value � element.
ElementType value(ListElement *element);

// ������ �� ����� list.
void print(List *list);

