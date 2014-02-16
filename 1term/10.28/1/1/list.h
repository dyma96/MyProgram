#pragma once

typedef int ElementType;

namespace list
{
	struct ListElement;
	typedef ListElement *Position;
	struct List;

	// �������� ������.
	List *create();
	// �������� �������� ������ �� ��������� value;
	Position createListElement(List *list, ElementType value);
	// ���������� �������� value ����� position.
	void addElement(List *list, ElementType value, Position position);
	// ���������� �������� value � ������ list. 
	void addElementToHead(List *list, ElementType value);
	// �������� �������� ����� position.
	void deleteElement(List *list, Position position);
	// �������� ����� list.
	void deleteList(List *list);
	// ��������� ������� ������� value � list.
	Position positionOfElement(List *list, ElementType value);
	// ���������� head � list.
	Position headListElement(List *list);
	// ���������� next � element.
	Position nextListElement(Position element);
	// ���������� value � element.
	ElementType valueListElement(List *list, Position element);
	// ������� ��������� ������� ����� temp ��������� next.
	void nextElementDoElement(List *list, Position temp, Position next);
	// ������ list.
	void print(List *list);
	// �������, ����������� ����� ������.
	Position endOfList(List *list);	
	// ���������� ���������� ��������� list.
	int lengthList(List *list);
}