/* Test is Ok -
 *              2: 87, 22
 *              5: 13, 73, 67, 60, 33
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sort;

namespace _3sort
{
    class Program
    {
        static void printMas(int[] mas, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(" {0} ", mas[i]);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter size of array:");
            string input = Console.ReadLine();
            int sizeArray  = Convert.ToInt32(input); 
            int[] mas = new int[sizeArray];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < sizeArray; i++)
                mas[i] = rand.Next(0,100);

            Console.WriteLine("Not sort mas:");
            printMas(mas, sizeArray);
            qSort.qsort(mas, 0, sizeArray - 1);
            Console.WriteLine("Sort mas:");
            printMas(mas, sizeArray);
            
        }
    }
}
