#pragma once
typedef char *ElementType;

namespace list
{
	struct List;
	struct ListElement;
	typedef ListElement *Position;
	// ������� ������� ������.
	List *create();
	// ���������� �������� value ����� position � list.
	void insert(List *list, ElementType value, Position position);
	// ���������� �������� value � ������ list.
	void insertToHead(List *list, ElementType value);
	// �������� list.
	void removeList(List *list);
	// ������� �������� ����� position � list.
	void remove(List *list, Position position);
	//  ��������� ������� �������� value � list.
	Position positionOfElement(List *list, ElementType value);
	// ������ list. 
	void print(List *list);

	// ���������� ������ ������� list.
	Position first(List *list);
	// ���������� ��������� ������� list.
	Position end(List *list);
	// ���������� ������� ����� position � list.
	Position next(List *list, Position position);
	// ���������� �������� �� ������� position � list.
	ElementType valueOnPosition(List *list, Position position);
	// ���������� ���������� �� value � list. ���� �����������, �� ������������� �� 1 numExist � ��� �������.
	bool exist(List *list, ElementType value);
}