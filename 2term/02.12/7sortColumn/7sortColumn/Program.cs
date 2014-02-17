﻿/* Test is Ok - 
 *              size = 2
 *              size = 3
 *              size = 5
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using sort;
using elemntType;

namespace _7sortColumn
{
    class Program
    {
        // печать массива на экран
        static void printMas(ElementType[] mas, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    mas[j].print(i);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter size array:");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            ElementType[] mas = new ElementType[sizeArray];
            for (int i = 0; i < sizeArray; i++)
                mas[i] = new ElementType(sizeArray);
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < sizeArray; i++)
                for (int j = 0; j < sizeArray; j++)
                    mas[i].mas[j] = rand.Next(100);
            Console.WriteLine("Not sort array:");
            printMas(mas, sizeArray);
            qSort.qsort(mas, 0, sizeArray - 1);
            Console.WriteLine("Sorted array to the first element of the column");
            printMas(mas, sizeArray);
        }
    }
}
