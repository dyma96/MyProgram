using System;
using NList;

namespace _2UniqueList
{
    public class UniqueList : List
    {
        public UniqueList()
        { }

        override public void AddElement(int value)
        {
            if (this.Exist(value))
                throw new ExceptionUniqueList("This element exist");
            else
                base.AddElement(value);
        }


        // add element to head with value value.
        override public void AddElementToHead(int value)
        {
            if (Exist(value))
                throw new ExceptionUniqueList("This element exist");
            else
                base.AddElementToHead(value);
            //head = new ListElement(value, head);
        }

        // delete element with value deleteNum.
        override public void DeleteElement(int deleteNum)
        {
            if (!Exist(deleteNum))
                throw new ExceptionUniqueList("Can't delete element.");
            else
                base.DeleteElement(deleteNum);
        }

    }
}
