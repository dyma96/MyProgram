#pragma once

typedef int ElementType;

namespace tree
{
	struct ListElement;
	struct Tree;
	// �������� ������� ������.
	Tree *create();
	// �������� tree.
	void remove(Tree *tree);
	// ���������� �������� value � tree.
	void addElement(Tree *tree, ElementType value);
	// ������ tree.
	void print(Tree *tree);
	// �������� tree �� �����.
	void createInFile(Tree *tree);
	// ���������� ������ tree.
	ListElement *route(Tree *tree);
	// ���������� ������� ������� � element.
	ListElement *right(ListElement *element);
	// ���������� ������ ������� � element.
	ListElement *left(ListElement *element);
	// ���������� �������� element.
	ElementType value(ListElement *element);
}