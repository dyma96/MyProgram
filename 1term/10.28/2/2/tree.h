#pragma once

typedef int ElementType;

namespace tree
{
	struct ListElement;
	struct Tree;

	// �������� ������� ������.
	Tree *create();
	// �������� ������ tree.
	void remove(Tree *tree);
	// ���������� �������� value � tree.
	void addElement(Tree *tree, ElementType value);
	// �������� ���������� �� ������� value � tree.
	bool existElement(Tree *tree, ElementType value);
	// ������ tree �� �������� � �������� ��� isPrintIsLeft = true, � ����� ��� isPrintIsLeft = false.
	void print(Tree *tree, bool isPrintIsLeft);
	// �������� �������� value �� ������ tree.
	void deleteElement(Tree *tree, ElementType value);
}