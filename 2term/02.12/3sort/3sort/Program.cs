/* Test is Ok -
 *              2: 87, 22
 *              5: 13, 73, 67, 60, 33
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3sort
{
    class Program
    {
        
        static void swap(ref int swapOne, ref int swapTwo)
        {
	        int swapSwap = swapOne;
	        swapOne = swapTwo;
	        swapTwo = swapSwap;
        }

        static void qsort(int[] mas, int begin, int end)
        {
	        int general = 0;
	        int i = 0;
	        for (i = 0; i < end - begin && mas[begin + i] == mas[begin]; i++) ;
	
	        if (mas[begin] == mas[begin + i])
		        return;
	        else if (mas[begin] < mas[begin + i])
		        general = mas[begin + i];
	        else
		        general = mas[begin];
	
	        int left = begin;
	        int right = end;

	        while (left < right)
	        {
		        while (mas[left] < general)
			        left++;
		        while (mas[right] >= general)
			        right--;
		        if (left >= right)
			        break;
		        swap(ref mas[left], ref mas[right]);

		        left++;
		        right--;
	        }		
	        qsort(mas, begin, right);
	        qsort(mas, left, end);	
        }


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
            qsort(mas, 0, sizeArray-1);
            Console.WriteLine("Sort mas:");
            printMas(mas, sizeArray);
            
        }
    }
}
