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
        private int val;

        public ElementType(int value)
        {
            val = value;
        }

        public static void swap(ref ElementType swapOne, ref ElementType swapTwo)
        {
            int swapSwap = swapOne.val;
            swapOne.val = swapTwo.val;
            swapTwo.val = swapSwap;
        }

        public int value()
        {
            return val;
        }

        public void print()
        {
            Console.Write("{0}, ", val);
        }
    }
}
