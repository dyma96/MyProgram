#pragma once

namespace hash
{
	struct HashTable;
	// �������� ��� �������.
	HashTable *createHashTable();
	// �������� ��� �������.
	void deleteHashTable(HashTable *hashTable);
	// ���������� � ��� ������� hashTable �������� newElement.
	void insertToHashTable(HashTable *hashTable, ElementType newElement);
	// ����������� � ��� ������� �������� element.
	bool exist(HashTable *hashTable, ElementType element);
	// �������� �� ��� ������� �������� element.
	void remove(HashTable *hashTable, ElementType element);
	// ������ hash.
	void print(HashTable *hash);

}