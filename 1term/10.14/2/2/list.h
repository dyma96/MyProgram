#pragma once

typedef int ElementType;

struct List;
struct ListElement;
//typedef ListElement *Position;

// �������� ������.
List *create();
// ���������� ������ �������� value � ������ list.
void insert(List *list, ElementType value);
// ���������� ������ �������� value � ������ ������ list.
void insertToHead(List *list, ElementType value);
// �������� �������� �� ������ list �� ��������� value.
void remove(List *list, ElementType value);
// ������ ������ list.
void print(List *list);
// �������� ������ list.
void deleteList(List *list);
// ����������� �������� ���� ���������.
void deleteListElement(ListElement *listElement);

