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

        // return value.
        public ElementType Value()
        {
            return this.value;
        }

        // return next element.
        public ListElement Next()
        {
            return this.next;
        }

        private ElementType value;
        private ListElement next;
    }
}
