using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2UniqueList
{
    public interface ListInterface
    {
        // add element to end with value value.
        void AddElement(int value);

        // add element after position pos.
        //void AddElementToPosition(int value, int pos);

        // add element to head with value value.
        void AddElementToHead(int value);

        // delete element with value deleteNum.
        void DeleteElement(int deleteNum);

        //return position element with vale value.
        //int PositionElement(int value);
        
        // return true or false - exist element value in stack.
        bool Exist(int value);

        // print stack.
        void Print();
    }
}
