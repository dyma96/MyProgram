#pragma once

// ����� ������ ����� list.
int lengthList(List *list);
// ���������� �������� ����� list. 
// ���� value = true, �� ���������� �� �����, ����� �� ��������.
List *mergeSort(List *list, bool value);
// �������� ������ �� ������, ��� ������.
bool isFirstMax(ListElement *first, ListElement *second, bool valueIsTelephone);