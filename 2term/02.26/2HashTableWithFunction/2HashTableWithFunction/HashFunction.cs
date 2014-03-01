using System;
using ElementType = System.Int32;

namespace _2HashTableWithFunction
{
    // Class with some hash function.
    public class ClassHashFunction
    {
        public delegate int HashFunction(ElementType Element);
        
        static public int HashFunction0(ElementType newElement)
        {
            return (int)newElement;
        }

        static public int HashFunction1(ElementType newElement)
        {
            return (newElement * (newElement + 5 * newElement % 3) / 2);
        }

        static public int HashFunction2(ElementType newElement)
        {
            return (newElement * newElement *(newElement % 4 + newElement % 3) / 2);
        }

        // Return function with numberFunction or HashFunction0.
        static public HashFunction Function(int numberFunction)
        {
            if (numberFunction == 0)
                return HashFunction0;
            if (numberFunction == 1)
                return HashFunction1;
            if (numberFunction == 2)
                return HashFunction2;

            return HashFunction0;
        }
    }
}
