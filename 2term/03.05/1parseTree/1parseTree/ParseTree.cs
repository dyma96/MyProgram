using System;
using System.IO;

namespace _1parseTree
{
    public class ParseTree: Tree 
    {
        public ParseTree(StreamReader file) : base(new TreeElement(file))
        {
        }
        
        /// <summary>
        /// Calculate result in parse tree.
        /// </summary>
        /// <returns> Result of calculate. </returns>
        public int Result()
        {
            if (this.Root() == null)
                return 0;
            return Root().Calculate();
        }

        /// <summary>
        /// Print tree.
        /// </summary>
        virtual public void Print()
        {
            Root().Print();
        }
    }
}
