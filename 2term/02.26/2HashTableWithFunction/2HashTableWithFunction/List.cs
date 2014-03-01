﻿using System;
using ElementType = System.Int32;
using Position = System.Int32;

namespace NList
{
    // It is magic class! it has a lot of supernatural abilities.
    public class List
    {
        public List()
        {
            head = null;
        }

        // Add element to end with value value.
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

        // Add element after position pos.
        public void AddElementToPosition(ElementType value, Position pos)
        {
            if (head == null)
            {
                head = new ListElement(value, null);
                return;
            }
            if (pos == 0)
            {
                AddElementToHead(value);
                return;
            }
            ListElement temp = head;
            int i = 0;
            for (i = 0; temp.Next() != null && i != pos - 1; temp = temp.Next(), i++) ;
            temp.AddListElement(value);
        }

        // Add element to head with value value.
        public void AddElementToHead(ElementType value)
        {
            head = new ListElement(value, head);
        }

        // Delete element with value deleteNum.
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

        // Return position element with vale value.
        public Position PositionElement(ElementType value)
        {
            ListElement temp = head;
            int i = 0;
            for (temp = head; temp != null && temp.Value() != value; temp = temp.Next(), i++) ;
            if (temp != null)
                return i;
            return -1;
        }

        // Return true or false - exist element value in stack.
        public bool Exist(ElementType value)
        {
            if (head == null)
                return false;
            ListElement temp = head;
            for (temp = head;  temp.Next() != null && temp.Value() != value; temp = temp.Next());
            return (temp.Value() == value);
        }

        // Print list.
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

        // This class have private element: value and pointer to the next element.
        // Have emty constructor, constructor with value and next element.
        // Can add and delete next element, return value and next element.
        private class ListElement
        {
            public ListElement()
            { }
            
            public ListElement(ElementType value, ListElement next)
            {
                this.value = value;
                this.next = next;
            }

            // Add element before this with value value.
            public void AddListElement(ElementType value)
            {
                ListElement temp = new ListElement(value, this.next);
                this.next = temp;
            }

            // Delete after this.
            public void DeleteListElement()
            {
                this.next = this.next.next;
            }

            // Return value of element.
            public ElementType Value()
            {
                return this.value;
            }

            // Return next element.
            public ListElement Next()
            {
                return this.next;
            }

            private ElementType value;
            private ListElement next;
        }
    }
}
