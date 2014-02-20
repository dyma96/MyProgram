using System;
using NList;

using ElementType = System.Int32;

namespace NHash
{
    class Hash
    {
        public Hash(int size)
        {
            bucket = new List[size];
            for (int i = 0; i < size; i++)
                bucket[i] = new List();
        }
        
        static int HashFunction(ElementType newElement)
        {
            return (newElement * (newElement + 5 * newElement % 3) / 2);
        }

        public void AddToHashTable(ElementType newElement)
        {
            if (ExistHash(newElement))
            {
                Console.WriteLine("Element exist");
                return;
            }
            bucket[HashFunction(newElement) % bucket.GetLength(0)].AddElementToHead(newElement);
        }

        public void DeleteElement(ElementType deleteElement)
        {
            if (!ExistHash(deleteElement))
            {
                Console.WriteLine("Element not exist");
                return;
            }
            bucket[HashFunction(deleteElement) % bucket.GetLength(0)].DeleteElement(deleteElement);
        }
        
        public bool ExistHash(ElementType element)
        {
            return bucket[HashFunction(element) % bucket.GetLength(0)].ExistList(element);
        }

        public void PrintHash()
        {
            for (int i = 0; i < bucket.GetLength(0); i++)
            {
                bucket[i].Print();
            }
        }
        private List[] bucket;
//        private const int size = 10;
    }
}
