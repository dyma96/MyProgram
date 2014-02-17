using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7sortColumn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size array:");
            //string input = Console.ReadLine();
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[sizeArray,sizeArray];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < sizeArray; i++)
                for (int j = 0; j < sizeArray; j++)
                    mas[i,j] = rand.Next(0, 100);

        }
    }
}
