using System;

namespace _1parseTree
{
    class Program
    {
        static void Main(string[] args)
        {
            ParseTree tree = new ParseTree(new System.IO.StreamReader("..//..//in.txt"));
            tree.Print();
            Console.WriteLine();
            Console.WriteLine(tree.Result());
        }
    }
}
