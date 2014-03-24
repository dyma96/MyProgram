using System;

namespace _1calculator
{
    public class Calculator
    {
        public Calculator()
        {
            stack = new Stack();
        }

        public string Print()
        {
            return this.stack.Print();
        }

        public void Add(int newValue)
        {
            if (this.stack.IsEmpty())
                this.stack.Push(newValue);
            else
            {
                this.stack.Push(newValue);
                Calculate();
            }
        }

        public void Add(char newValue)
        {
            if (this.stack.IsEmpty())
                return;
            int previous = this.stack.Pop();
            if (this.stack.IsEmpty())
            {
                this.stack.Push(previous);
                this.stack.Push(newValue);
            }
            else
            {
                this.stack.Push(previous);
                this.Calculate();
                this.stack.Push(newValue);
            }
/*            if (newValue == '+' || newValue == '-' || newValue == '*' 
                || newValue == '/' || newValue == '=')
            {
                AddSign(newValue);
                return;
            }

            if (stack.IsEmpty())
                stack.Push(newValue - '0');
            else
            {
                int firstValue = stack.Pop();
                if (stack.IsEmpty())
                    stack.Push(firstValue * 10 + newValue - '0');
                else
                {
                    int secondValue = stack.Pop();
                    if (stack.IsEmpty())
                    {
                        stack.Push(secondValue);
                        stack.Push(firstValue);
                        stack.Push(newValue - '0');
                    }
                    else
                    {
                        stack.Push(secondValue);
                        stack.Push(firstValue * 10 + newValue - '0');
                    }
                }
            }
 */
        }
 
        private void AddSign(char newValue)
        {
            if (stack.IsEmpty())
                return;
            if (newValue == '=')
                Calculate();
            else
            {
                int firstValue = stack.Pop();
                if (stack.IsEmpty())
                {
                    stack.Push(firstValue);
                    stack.Push(newValue);
                }
                else
                {
                    int secondValue = stack.Pop();
                    if (stack.IsEmpty())
                    {
                        stack.Push(secondValue);
                        stack.Push(newValue);
                    }
                    else
                    {
                        stack.Push(secondValue);
                        stack.Push(firstValue);
                        Calculate();
                        stack.Push(newValue);
                    }
                }
            }
        }

        private void Calculate()
        {
            int rightValue = 0;
            int leftValue = 0;
            char sign = '0';
            if (!stack.IsEmpty())
                rightValue = stack.Pop();
            else
                return;
            if (!stack.IsEmpty())
                sign = (char) stack.Pop();
            else
            {
                stack.Push(rightValue);
                return;
            }
            if (!stack.IsEmpty())
                leftValue = stack.Pop();
            else
            {
                stack.Push(rightValue);
                return;
            }
            stack.Push(CalculateTwoNumbers(leftValue, rightValue, sign));
        }

        private int CalculateTwoNumbers(int left, int right, char sign)
        {
            if (sign == '+')
                return left + right;
            if (sign == '-')
                return left - right;
            if (sign == '*')
                return left * right;
            if (sign == '/' && right != 0)
                return left / right;

            return 0;
        }

        private Stack stack;
    }
}
