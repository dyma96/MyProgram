using System;

namespace _1parseTree
{
    /// <summary>
    /// Element of tree - with value and two children - left and right.
    /// </summary>
    public class TreeElement
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

        public TreeElement(System.IO.StreamReader file)
        {
            value = 0;
            left = null;
            right = null;

            if (file.EndOfStream)
                return;
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
                
                left = new TreeElement(file);
                right = new TreeElement(file);
            }

            else if (ch <= '9' && ch >= '0')
            {
                int number = 0;
                while (ch <= '9' && ch >= '0')
                {
                    number = number * 10 + ch - '0';
                    ch = file.Read();
                }
                // if ch != ' ' - error
                if (ch != ' ')
                    throw new ExeptionParseTree("Waiting ' '.");
                
                value = number;
            }
            else
                throw new ExeptionParseTree("Waiting '(' or number.");
        }

        /// <summary>
        /// Add element to left or right.
        /// </summary>
        /// <param name="value"> Value new element. </param>
        /// <param name="isLeft"> Is it lift or right. </param>
        public void AddTreeElement(int value, bool isLeft)
        {
            if (isLeft)
                this.left = new TreeElement(value);
            else
                this.right = new TreeElement(value);
        }

        /// <summary>
        /// </summary>
        /// <returns> Result calculate left and right children. </returns>
        public int Calculate()
        {
            int leftValue = 0;
            if (left != null)
                leftValue = left.Calculate();
            else
                return value;

            int rightValue = 0;
            if (right != null)
                rightValue = right.Calculate();
            else
                return value;

            if (value == '+')
                return leftValue + rightValue;
            if (value == '-')
                return leftValue - rightValue;
            if (value == '*')
                return leftValue * rightValue;
            if (value == '/')
                return leftValue / rightValue;
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
        public int Value()
        {
            return value;
        }

        /// <summary>
        /// </summary>
        /// <returns> Right child. </returns>
        public TreeElement Right()
        {
            return right;
        }
        
        /// <summary>
        /// </summary>
        /// <returns> Left child. </returns>
        public TreeElement Left()
        {
            return left;
        }

        private int value;
        private TreeElement left;
        private TreeElement right;
    }
}
