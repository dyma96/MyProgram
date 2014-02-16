#pragma once

typedef char ElementType;

struct Stack;
struct ListElement;

// �������� �����.
Stack *createStack();
// ���������� �������� value � stack.
void addElementStack(Stack *stack, ElementType value);
// �������� � ������ stack.
ElementType valueHeadStack(Stack *stack);
// �������� �������� stack.
void deleteStackElement(Stack *stack);
// �������� ����� stack.
void deleteStack(Stack *stack);
// ������ �� stack.
bool isEmptyStack(Stack *stack);
