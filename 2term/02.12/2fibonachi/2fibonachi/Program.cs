/* Test is Ok -
 *              1 = 1
 *              3 = 2
 *              10 = 55
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2fibonachi
{
    class Program
    {
        // Подсчет числа Фибоначчи с номером num.
        static int Fibonachi(int num)
        {
            if (num <= 2)
                return 1;
            return Fibonachi(num - 1) + Fibonachi(num - 2);
        }
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number of Fibonachi:");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            System.Console.WriteLine("{0} number Fibonachi = {1}", num, Fibonachi(num));
        }
    }
}
