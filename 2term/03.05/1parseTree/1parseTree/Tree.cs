using System;
using System.IO;
using ElementType = System.Int32;
using Position = System.Int32;

namespace _1parseTree
{
    public class Tree
    {
        public Tree(TreeElement root)
        {
            this.root = root;
        }

        /// <summary>
        /// Print tree.
        /// </summary>
        public void Print()
        {
            root.Print();
        }

        /// <summary>
        /// </summary>
        /// <returns> Root this tree. </returns>
        public TreeElement Root()
        {
            return root;
        }
 
        /// <summary>
        /// Add new element in tree.
        /// </summary>
        /// <param name="value"> Value new element. </param>
        public void AddElement(ElementType value)
        {
            TreeElement temp = this.root;
            TreeElement tempPrevious = temp;
            while (temp != null)
            {
                tempPrevious = temp;
                if (value == temp.Value())
                {
                    Console.WriteLine("Element {0} exist", value);
                    return;
                }

                if (value > temp.Value())
                    temp = temp.Right();
                else
                    temp = temp.Left();
            }

            temp = tempPrevious;
            if (temp == null)
                root = new TreeElement(value);
            else if (value > temp.Value())
                temp.AddTreeElement(value, false);
            else
                temp.AddTreeElement(value, true);

        }

        private TreeElement root;
    }
}