using System;
using NStack;

namespace NCalculator
{
    class Calculator
    {
        public Calculator()
        {
            stack = new Stack();
        }
        
        public void AddNumber(int newNumber)
        {
            stack.Push(newNumber);
        }

        public void AddSign(char sign)
        {
            CalculateTwoNumbers(sign);
        }

        public int OutputResult()
        {
            return stack.ValueHead();
        }

/*        public void CreatePost()
        {
            string str = Console.ReadLine();
            foreach (char ch in str)
            {
                if (ch == ' ')
                    continue;
                if (ch >= '0' && ch <= '9')
                    stack.Push(ch - '0');
                else
                    CalculateTwoNumbers(stack, ch);
            }
            Console.WriteLine("result: {0}", stack.ValueHead());
            //return stack;
        }
*/
        private void CalculateTwoNumbers(char sign)
        {
	        int value1 = stack.Pop();
	        int value2 = stack.Pop();
	        int valueResult = 0;
	        if (sign == '+')
		        valueResult = value1 + value2; 
	        else if (sign == '-')
		        valueResult = value2 - value1; 
	        else if (sign == '*')
		        valueResult = value1 * value2; 
	        else if (sign == '/')
		        valueResult = value2 / value1; 
	        stack.Push(valueResult);
        }

        private Stack stack;
    }
}
