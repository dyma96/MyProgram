using System;
using NList;

using ElementType = System.Int32;

namespace _2HashTableWithFunction
{
    // This class keep elemenets in hash table.
    public class HashTable
    {
        public HashTable(int size)
        {
            bucket = new List[size];
            for (int i = 0; i < size; i++)
                bucket[i] = new List();
            HashFunction = ClassHashFunction.HashFunction0;
        }

        // Constructor with size hash table and number hash function. 
        public HashTable(int size, int numberFunction)
        {
            bucket = new List[size];
            for (int i = 0; i < size; i++)
                bucket[i] = new List();

            HashFunction = ClassHashFunction.Function(numberFunction);
        }

        // Add element to hash table with value newElement. 
        public void AddToHashTable(ElementType newElement)
        {
            if (Exist(newElement))
            {
                Console.WriteLine("Element exist");
                return;
            }
            bucket[HashFunction(newElement) % bucket.GetLength(0)].AddElementToHead(newElement);
        }

        // Delete element wit value deleteElemenet.
        public void DeleteElement(ElementType deleteElement)
        {
            if (!Exist(deleteElement))
            {
                Console.WriteLine("Element not exist");
                return;
            }
            bucket[HashFunction(deleteElement) % bucket.GetLength(0)].DeleteElement(deleteElement);
        }
        
        // Return tru or false: exist element with value element.
        public bool Exist(ElementType element)
        {
            return bucket[HashFunction(element) % bucket.GetLength(0)].Exist(element);
        }

        // Print hash table.
        public void PrintHash()
        {
            for (int i = 0; i < bucket.GetLength(0); i++)
            {
                bucket[i].Print();
            }
        }
        private List[] bucket;
        private ClassHashFunction.HashFunction HashFunction;
    }
}
