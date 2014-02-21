using System;
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

        public bool ExistList(ElementType value)
        {
            if (head == null)
                return false;
            ListElement temp = head;
            for (temp = head;  temp.Next() != null && temp.Value() != value; temp = temp.Next());
            return (temp.Value() == value);
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

        private class ListElement
        {
            public ListElement()
            { }

            public ListElement(ElementType value, ListElement next)
            {
                this.value = value;
                this.next = next;
            }

            public void AddListElement(ElementType value)
            {
                ListElement temp = new ListElement(value, this.next);
                this.next = temp;
            }

            // delete after this.
            public void DeleteListElement()
            {
                this.next = this.next.next;
            }

            public ElementType Value()
            {
                return this.value;
            }

            public ListElement Next()
            {
                return this.next;
            }

            private ElementType value;
            private ListElement next;
        }

    }
}
