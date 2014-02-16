#pragma once

typedef char ElementType;

struct Stack;
struct ListElement;

// �������� �����.
Stack *create();
// ���������� �������� value � stack.
void addElement(Stack *stack, ElementType value);
// �������� � ������ stack.
ElementType valueHead(Stack *stack);
// �������� �������� stack.
void deleteElement(Stack *stack);
// �������� ����� stack.
void deleteStack(Stack *stack);
// ������ �� stack.
bool isEmpty(Stack *stack);
