#pragma once

struct List;
struct ListElement;
struct ElementType;
typedef ListElement *Position;

// �������� ������.
List *create();
// �������� ������ �� ����� file.
List *createList(FILE *file);
// �������� ������ list.
void removeList(List *list);

// ������ ������ list.
ListElement *headList(List *list);
// ��������� ������� �������� element.
ListElement *nextListElement(ListElement *element);
// ���������� ������� �������� element.
ListElement *previousListElement(ListElement *element);
// �������� � �������� element.
ElementType valueListElement(ListElement *element);
// ������� element.
int telephoneListElement(ListElement *element);
// ��� element.
char *nameElement(ListElement *element);

// ������� ��������� ��������� next.
ListElement *doNextElement(ListElement *element, ListElement *next);
// ������� ���������� ��������� previous.
ListElement *doPreviousElement(ListElement *element, ListElement *previous);

// ������� ��������� �� ��������� ������� NULL. 
void nextElementDoElement(ListElement *element, ListElement *nextElement);
// ������� ��������� �� ���������� ������� NULL.
void previousElementDoNULL(ListElement *element);
// ������� ������ � head element.
List *makeList(ListElement *element);

// ������ ������ list.
void print(List *list);

void deleteList(List *list);

void printMemory();
