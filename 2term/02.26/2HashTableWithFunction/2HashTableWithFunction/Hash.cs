using System;
using NList;

using ElementType = System.Int32;

namespace _2HashTableWithFunction
{
    /// <summary>
    /// This class keep elemenets in hash table.
    /// </summary>
    public class HashTable
    {
        public HashTable(int size)
        {
            bucket = new List[size];
            for (int i = 0; i < size; i++)
                bucket[i] = new List();
            HashFunction = ClassHashFunction.HashFunction0;
        }

        /// <summary>
        /// Constructor with size hash table and number hash function. 
        /// </summary>
        /// <param name="size"></param>
        /// <param name="numberFunction"></param>
        public HashTable(int size, int numberFunction)
        {
            bucket = new List[size];
            for (int i = 0; i < size; i++)
                bucket[i] = new List();

            HashFunction = ClassHashFunction.Function(numberFunction);
        }

        /// <summary>
        /// Add element to hash table with value newElement.  
        /// </summary>
        /// <param name="newElement"></param>
        public void AddToHashTable(ElementType newElement)
        {
            if (Exist(newElement))
            {
                Console.WriteLine("Element exist");
                return;
            }
            bucket[HashFunction(newElement) % bucket.GetLength(0)].AddElementToHead(newElement);
        }

        /// <summary>
        /// Delete element wit value deleteElemenet. 
        /// </summary>
        /// <param name="deleteElement"></param>
        public void DeleteElement(ElementType deleteElement)
        {
            if (!Exist(deleteElement))
            {
                Console.WriteLine("Element not exist");
                return;
            }
            bucket[HashFunction(deleteElement) % bucket.GetLength(0)].DeleteElement(deleteElement);
        }
        
        /// <summary>
        /// Return tru or false: exist element with value element. 
        /// </summary>
        /// <param name="element"></param>
        /// <returns> Exist element or not </returns>
        public bool Exist(ElementType element)
        {
            return bucket[HashFunction(element) % bucket.GetLength(0)].Exist(element);
        }

        /// <summary>
        /// Print hash table. 
        /// </summary>
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
