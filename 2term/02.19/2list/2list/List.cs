using System;
using NListElement;
using ElementType = System.Int32;

namespace NList
{
    class List
    {
        public List()
        {
            head = null;
        }

        public void AddElement(ElementType value)
        {
            if (head == null)
            {
                head = new ListElement(value, null);
                return;
            }
            ListElement temp = head;
            for (temp = head; temp.Next() != null; temp = temp.Next()) ;
            temp.AddListElement(value);
        }

        public void AddElementToHead(ElementType value)
        {
            head = new ListElement(value, head);
        }

        public void DeleteElement(ElementType deleteNum)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            ListElement temp = head;
            if (head.Value() == deleteNum)
                head = head.Next();
            else
            {
                while (temp.Next() != null && temp.Next().Value() != deleteNum)
                    temp = temp.Next();
                if (temp.Next() != null)
                    temp.DeleteListElement();
            }
        }

        public bool Exist(ElementType value)
        {
            if (head == null)
                return false;
            ListElement temp = head;
            for (temp = head;  temp.Next() != null && temp.Value() != value; temp = temp.Next());
            return (temp.Value() == value);
        }

        public ListElement Head()
        {
            return head;
        }

        public ListElement Next(ListElement element)
        {
            return element.Next();
        }

        public ElementType Value(ListElement element)
        {
            return element.Value();
        }

        public void Print()
        {
            Console.WriteLine();
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            ListElement temp = head;
            for (temp = head; temp.Next() != null; temp = temp.Next())
                Console.Write("{0}, ", temp.Value());
            Console.WriteLine("{0}", temp.Value());
        }

        private ListElement head;
    }
}
