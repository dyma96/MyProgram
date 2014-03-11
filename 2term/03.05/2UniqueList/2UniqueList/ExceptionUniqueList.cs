using System;

namespace _2UniqueList
{
    [Serializable]
    public class ExceptionUniqueList : ApplicationException
    {
        public ExceptionUniqueList()
        { }

        public ExceptionUniqueList(string message): base(message)
        { }
    }
}
