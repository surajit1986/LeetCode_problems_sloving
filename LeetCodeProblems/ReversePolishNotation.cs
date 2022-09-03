using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    //Reverse Polish Notation ex: (2 +5) *3 = 21
    //check if element is operand (ex: 1,2,3,etc) push it into stack
    //check if element is opeartor(ex: +,-,*,/) pop 2 elements from stack and perform the operation
    //push the result into stack
    //take the last element from stack to show the result
    internal class ReversePolishNotation
    {
        public void ReversePolishNotationEXpression(char[] exprssion)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < exprssion.Length; i++)
            {
                if ((exprssion[i] == '+') || (exprssion[i] == '-') || (exprssion[i] == '*') || (exprssion[i] == '/'))
                {
                    var v1 = stack.Peek();
                    stack.Pop();
                    var v2 = stack.Peek();
                    stack.Pop();
                    if ((exprssion[i] == '+'))
                    {
                        stack.Push(v1 + v2);
                    }
                    else if ((exprssion[i] == '-'))
                    {
                        stack.Push(v1 - v2);
                    }
                    else if ((exprssion[i] == '*'))
                    {
                        stack.Push(v1 * v2);
                    }
                    else if ((exprssion[i] == '/'))
                    {
                       stack.Push(v1 / v2);
                    }
                }
                else
                {
                    stack.Push(Convert.ToInt32(exprssion[i].ToString()));
                }
            }
            Console.WriteLine(stack.Peek());

        }
    }
}
