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
            HashFunction = new HashFunctionClass0();
        }
        
        /// <summary>
        /// Constructor with size hash table and number hash function. 
        /// </summary>
        /// <param name="size"></param>
        /// <param name="numberFunction"></param>
        public HashTable(int size, HashFunctionInterface func)
        {
            bucket = new List[size];
            for (int i = 0; i < size; i++)
                bucket[i] = new List();

            HashFunction = func;
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
            bucket[HashFunction.function(newElement) % bucket.GetLength(0)].AddElementToHead(newElement);
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
            bucket[HashFunction.function(deleteElement) % bucket.GetLength(0)].DeleteElement(deleteElement);
        }
        
        /// <summary>
        /// Return tru or false: exist element with value element. 
        /// </summary>
        /// <param name="element"></param>
        /// <returns> Exist element or not </returns>
        public bool Exist(ElementType element)
        {
            return bucket[HashFunction.function(element) % bucket.GetLength(0)].Exist(element);
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
        
        /// <summary>
        /// Function to change hash function without delete elements
        /// </summary>
        /// <param name="func"></param>
        public void ChangeHashFunction(HashFunctionInterface func)
        {
            List[] temp = new List[bucket.GetLength(0)];
            for (int i = 0; i < bucket.GetLength(0); i++)
                temp[i] = new List();
            
            for (int i = 0; i < bucket.GetLength(0); i++)
            {
                while (!bucket[i].IsEmpty())
                {
                    temp[func.function(bucket[i].ValueHead()) % temp.GetLength(0)]
                        .AddElementToHead(bucket[i].ValueHead());
                    bucket[i].DeleteElement(bucket[i].ValueHead());
                }
            }
            HashFunction = func;
            bucket = temp;
        }

        private List[] bucket;
        HashFunctionInterface HashFunction;
        
    }
}
