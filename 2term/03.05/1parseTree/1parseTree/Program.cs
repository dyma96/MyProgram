using System;

namespace _1parseTree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ParseTree tree = new ParseTree(new System.IO.StreamReader("..//..//in.txt"));
                tree.Print();
                Console.WriteLine();
                Console.WriteLine(tree.Result());
            }
            catch (ExeptionParseTree exept)
            {
                Console.WriteLine("Error." + exept.Message);
                Console.WriteLine("Format: ( sign ( operand ) ( operand ) )");
            }
        }
    }
}
