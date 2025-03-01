using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicQuestions
{
    /// <summary>
    /// Question Link: https://leetcode.com/problems/valid-parentheses/description/
    /// </summary>
    public class ValidParentheses
    {
        public bool IsValid(string input)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '[' | input[i] == '(' || input[i] == '{')
                    stack.Push(input[i]);

                if (stack.Count == 0)
                    return false;


                if (input[i] == ']' && stack.Pop() != '[' ||
                   input[i] == ')' && stack.Pop() != '(' ||
                   input[i] == '}' && stack.Pop() != '{')
                    return false;



            }

            return stack.Count == 0;

        }


    }
}
