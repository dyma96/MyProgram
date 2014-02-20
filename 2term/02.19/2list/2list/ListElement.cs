using System;

using ElementType = System.Int32;

namespace NListElement
{
    class ListElement
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
