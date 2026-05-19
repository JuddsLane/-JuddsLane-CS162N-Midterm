using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a word: ");
                string input = Regex.Replace(Console.ReadLine(), "[^a-zA-Z0-9]", "");
                input = input.ToLower();
                Console.WriteLine(IsPalindrome(input) ? "Your word is a palindrome." : "Your word is not a pallindrome.");
            }
        }

        static bool IsPalindrome(string s)
        {
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            foreach(char c in s)
            {
                stack.Push(c);
                queue.Enqueue(c);
            }

            while(stack.Count > 0)
            {
                if(stack.Pop() != queue.Dequeue())
                    return false;
            }

            return true;
        }
    }
}
