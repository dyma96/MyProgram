/* Test is Ok - 
 *              3! = 6
 *              5! = 120
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1factorail
{
    class Program
    {
        // Подсчет факториала числа num.
        static int factorial(int num)
        {
            if (num == 1)
                return 1;
            return num * factorial(num - 1);
        }

        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Enter number for factorial:");
            string input = Console.ReadLine();
            num = Convert.ToInt32(input);
            Console.WriteLine("{0}! = {1}", num, factorial(num));
        }
    }
}
