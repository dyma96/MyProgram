using System;

namespace _2UniqueList
{
    public class UniqueList: ListInterface
    {
        public UniqueList()
        {
            head = null; 
        }

        public void AddElement(int value)
        {
            if (this.Exist(value))
                throw new ExceptionUniqueList("This element exist");
            else
                this.AddElementList(value);
        }

        // add element to end with value value.
        private void AddElementList(int value)
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

        // add element to head with value value.
        virtual public void AddElementToHead(int value)
        {
            if (Exist(value))
                throw new ExceptionUniqueList("This element exist");
            else
                head = new ListElement(value, head);
        }

        // delete element with value deleteNum.
        public void DeleteElement(int deleteNum)
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
                else 
                    throw new ExceptionUniqueList("Can't delete element.");
            }
        }

        // return true or false - exist element value in stack.
        public bool Exist(int value)
        {
            if (head == null)
                return false;
            ListElement temp = head;
            for (temp = head;  temp.Next() != null && temp.Value() != value; temp = temp.Next());
            return (temp.Value() == value);
        }

        // print stack.
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

            // do this element with value and next.
            public ListElement(int value, ListElement next)
            {
                this.value = value;
                this.next = next;
            }

            // add element before this with value value.
            public void AddListElement(int value)
            {
                ListElement temp = new ListElement(value, this.next);
                this.next = temp;
            }

            // delete after this.
            public void DeleteListElement()
            {
                this.next = this.next.next;
            }

            // return value of element.
            public int Value()
            {
                return this.value;
            }

            // return next element.
            public ListElement Next()
            {
                return this.next;
            }

            private int value;
            private ListElement next;
        }

    }
}
