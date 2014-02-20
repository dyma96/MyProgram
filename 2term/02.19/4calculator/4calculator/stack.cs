using System;

using NListElement;
using ElementType = System.Int32;

namespace NStack
{
    public class Stack
    {
        public Stack()
        {
            head = null;
        }

        // add element newValue to head.
        public void Push(ElementType newValue)
        {
            ListElement temp = new ListElement(newValue, head);
            head = temp;
        }

        // delete element in head and return value.
        public ElementType Pop()
        {
            if (head == null)
                return -1;
            ElementType val = head.Value();
            head = head.Next();
            return val; 
        }

        // print stack.
        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            ListElement pos = head;
            for (pos = head; pos.Next() != null; pos = pos.Next())
                Console.Write("{0} -> ", pos.Value());
            Console.Write("{0}", pos.Value()); 
            Console.WriteLine();
        }

        // return value of head.
        public ElementType ValueHead()
        {
            return head.Value();
        }
       private ListElement head;
    }
}
