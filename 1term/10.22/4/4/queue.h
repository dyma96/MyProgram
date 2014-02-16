#pragma once

typedef char ElementType;

struct ListElement;
struct Queue;

// �������� �������.
Queue *createQueue();
// ���������� � ����� �������� value � queue.
void enqueue(Queue *queue, ElementType value);
// ���������� �������� � ������ queue � �������� ���.
ElementType dequeue(Queue *queue);
// �������� queue.
void deleteQueue(Queue *queue);
// ��������u ������ queue.
void deleteQueueElement(Queue *queue);

// ������ queue.
void printQueue(Queue *queue);

