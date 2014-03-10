using System;

namespace _1parseTree
{
    [Serializable]
    public class ExeptionParseTree : ApplicationException
    {
        public ExeptionParseTree()
        { }

        public ExeptionParseTree(string message): base(message)
        { }
    }
}
