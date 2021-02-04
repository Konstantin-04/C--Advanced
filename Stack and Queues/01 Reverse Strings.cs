using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // First way to solve

            /*string input = Console.ReadLine();
            Stack<char> reverseString = new Stack<char>(input);
            Console.WriteLine(string.Join("", reverseString));*/

            // Second way to solve

            string input = Console.ReadLine();
            char[] characters = input.ToCharArray();
            Stack<char> reverseString = new Stack<char>();

            for (int i = 0; i < characters.Length; i++)
            {
                reverseString.Push(characters[i]);
            }

            while (reverseString.Count > 0)
            {
                Console.Write(reverseString.Pop());
            }
        }
    }
}
