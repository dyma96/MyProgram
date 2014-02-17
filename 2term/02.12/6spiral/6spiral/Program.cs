/* Test is Ok -
 *              size = 3
 *              size = 5
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6spiral
{
    class Program
    {
        // обычная печать массива.
        static void printMas(int[,] mas, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write("{0} ", mas[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // вывод массива mas по спирали с нечетным количеством элементов size.
        static void printMasSpiral(int[,] mas, int size)
        {
            int speed = 0; // 0 - left, 1 - down, 2 - right, 3 - up
            int i = (size - 1) / 2;
            int j = (size - 1) / 2;
            int minI = i - 1;
            int maxI = i + 1;
            int minJ = j - 1;
            int maxJ = j + 1;
            while (i != 0 || j != 0)
            {
                Console.Write("{0}, " , mas[i,j]);
                if (speed == 0)
                    j--;
                else if (speed == 1)
                    i++;
                else if (speed == 2)
                    j++;
                else if (speed == 3)
                    i--;
                if (j <= minJ && speed == 0)
                {
                    speed = 1;
                    minJ--;
                }
                else if (j >= maxJ && speed == 2)
                {
                    speed = 3;
                    maxJ++;
                }
                else if (i >= maxI && speed == 1)
                { 
                    speed = 2;
                    maxI++;
                }
                else if (i <= minI && speed == 3)
                {
                    speed = 0;
                    minI--;
                }

                if (minI < 0)
                    minI = 0;
                if (minJ < 0)
                    minJ = 0;
                if (maxI > size - 1)
                    maxI = size - 1;
                if (maxJ > size - 1)
                    maxJ = size - 1;
            }
            Console.WriteLine("{0}", mas[0, 0]);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter odd size of array:");
            string input = Console.ReadLine();
            int sizeArray = Convert.ToInt32(input);
            if (sizeArray % 2 == 0)
                sizeArray--;
            int[,] mas = new int[sizeArray, sizeArray];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < sizeArray; i++)
                for (int j = 0; j < sizeArray; j++)
                    mas[i,j] = rand.Next(0, 100);

            printMas(mas, sizeArray);
            printMasSpiral(mas, sizeArray);
        }
    }
}
