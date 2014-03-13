using System;
using System.IO;
using ElementType = System.Int32;
using Position = System.Int32;

namespace _1parseTree
{
    public class Tree
    {
        public Tree(System.IO.StreamReader file)
        {
            root = createTreeFromFile(file, root);
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
        public int Root
        {
            get { return root.Value; }
        }

        public int Result()
        {
            if (root == null)
                return 0;
            return root.Calculate();
        }


        private TreeElement createTreeFromFile
            (System.IO.StreamReader file, TreeElement treeElement)
        {
            int value = 0;
            TreeElement left = null;
            TreeElement right = null;

            if (file.EndOfStream)
                return treeElement;
            int ch = file.Read(); //  '(' или цифра
            if (ch == '(')
            {
                ch = file.Read();  // ' '
                if (ch != ' ')
                    throw new ExeptionParseTree("Waiting ' '.");

                ch = file.Read();  // sign
                if (ch != '+' && ch != '-' && ch != '*' && ch != '/')
                    throw new ExeptionParseTree("Waiting sign.");

                value = ch;
                ch = file.Read();  // ' '
                if (ch != ' ')
                    throw new ExeptionParseTree("Waiting ' '.");

                left = createTreeFromFile(file, left);
                right = createTreeFromFile(file, right);

                if (value == '+')
                    treeElement = new Add(value, left, right);
                if (value == '-')
                    treeElement = new Subtract(value, left, right);
                if (value == '*')
                    treeElement = new Multiply(value, left, right);
                if (value == '/')
                    treeElement = new Divide(value, left, right);
            }

            else if (ch <= '9' && ch >= '0')
            {
                int number = 0;
                while (ch <= '9' && ch >= '0')
                {
                    number = number * 10 + ch - '0';
                    ch = file.Read();
                }
                if (ch != ' ')
                    throw new ExeptionParseTree("Waiting ' '.");

                value = number;
                treeElement = new Value(value, null, null);
            }
            else
                throw new ExeptionParseTree("Waiting '(' or number.");
            return treeElement;
        }
        
        private TreeElement root;

        /// <summary>
        /// Element of tree - with value and two children - left and right.
        /// </summary>
        private class TreeElement
        {
            public TreeElement()
            { }

            public TreeElement(int value)
            {
                this.value = value;
            }

            public TreeElement(int value, TreeElement left, TreeElement right)
            {
                this.value = value;
                this.left = left;
                this.right = right;
            }


            /// <summary>
            /// </summary>
            /// <returns> Result calculate left and right children. </returns>
            public virtual int Calculate()
            {
                return 0;
            }
            
            /// <summary>
            /// Print tree in recursion.
            /// </summary>
            public void Print()
            {
                if (left != null && right != null)
                    Console.Write("(");

                if (left != null)
                    left.Print();
                if (left == null && right == null)
                    Console.Write(value + " ");
                else
                    Console.Write((char)value + " ");
                if (right != null)
                    right.Print();

                if (left != null && right != null)
                    Console.Write(")");
            }

            /// <summary>
            /// </summary>
            /// <returns> Value this element. </returns>
            public int Value
            {
                get { return value; }
            }

            /// <summary>
            /// </summary>
            /// <returns> Right child. </returns>
            public TreeElement Right
            {
                get { return right; }
            }

            /// <summary>
            /// </summary>
            /// <returns> Left child. </returns>
            public TreeElement Left
            {
                get { return left; }
            }

            private int value;
            private TreeElement left;
            private TreeElement right;
        }

        /// <summary>
        /// Some class Operation and Value. 
        /// </summary>
        
        private class Add: TreeElement
        {
            public Add(int value, TreeElement left, TreeElement right)
                : base(value, left, right)
            { }

            override public int Calculate() 
            {
                if (Left == null || Right == null)
                    throw new ExeptionParseTree("Can't calculate. Error in tree");
                return Left.Value + Right.Value;
            }
        }

        private class Subtract : TreeElement
        {
            public Subtract(int value, TreeElement left, TreeElement right)
                : base(value, left, right)
            { }

            public override int Calculate()
            {
                if (Left == null || Right == null)
                    throw new ExeptionParseTree("Can't calculate. Error in tree");
                return Left.Value - Right.Value;
            }
        }

        private class Multiply : TreeElement
        {
            public Multiply(int value, TreeElement left, TreeElement right)
                : base(value, left, right)
            { }

            public override int Calculate()
            {
                if (Left == null || Right == null)
                    throw new ExeptionParseTree("Can't calculate. Error in tree");
                return Left.Value * Right.Value;
            }
        }

        private class Divide : TreeElement
        {
            public Divide(int value, TreeElement left, TreeElement right)
                : base(value, left, right)
            { }

            public override int Calculate()
            {
                if (Left == null || Right == null)
                    throw new ExeptionParseTree("Can't calculate. Error in tree");
                return Left.Value / Right.Value;
            }
        }

        private class Value: TreeElement
        {
            public Value(int value, TreeElement left, TreeElement right)
                : base(value, left, right)
            { }

            public override int Calculate()
            {
                return Value;
            }
        }
    }
}