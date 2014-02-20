/* Test is Ok -
 *              1 2 + = 3
 *              1 2 3 + - = -4
 */
using System;
using NStack;

namespace NCalculator
{
    class Calculator
    {
        static public void CreatePost()
        {
            Stack stack = new Stack();
            Console.WriteLine("Enter example of postfix notation:");
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

        static private void CalculateTwoNumbers(Stack stack, char sign)
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

    }
}
