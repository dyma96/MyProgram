using System;
using System.IO;

namespace _1parseTree
{
    public class ParseTree: Tree 
    {
        /// <summary>
        /// Constructor, which read information in file.
        /// </summary>
        /// <param name="file"> File with information for tree. </param>
        public ParseTree(StreamReader file) : base(file)
        {
        }
        
    }
}
