using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elemntType
{
    // тип, элемент которого массив, определяемый по первому значению.
    class ElementType
    {
        public int[] mas;
        public int sizeArray;
        public ElementType(int size)
        {
            sizeArray = size;
            mas = new int[sizeArray];
            // при такой реализации больгая част массива заполняется одинаково.
            /* Random rand = new Random(DateTime.Now.Millisecond);
            for (int j = 0; j < sizeArray; j++)
                mas[j] = rand.Next(100);*/
        }

        public static void swap(ref ElementType swapOne, ref ElementType swapTwo)
        {
            int[] swapSwap = swapOne.mas;
            swapOne.mas = swapTwo.mas;
            swapTwo.mas = swapSwap;
        }

        public int value()
        {
            return mas[0];
        }

        public void print(int numOfLine)
        {
            Console.Write("{0}, ", mas[numOfLine]);
        }
    }
}
