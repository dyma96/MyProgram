#pragma once

// ��������� � ����� ������ country - ������ �����, ���������� ������ �����.
int **create(int country[]);

// ���������� ������ �������, �������� �������� �������� ������, ������� ����������� ������.
void makeCountry(int country[], int **floydGraph, int numberCity, int city[]);

// ����� �� ������� ����� � ������� ��� �������������.
void print(int city[], int country[], int numberCity);


