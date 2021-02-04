using System;
using System.Linq;
using System.Collections.Generic;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNubers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(inputNubers);

            string[] commands = Console.ReadLine().Split();
            string command = commands[0];

            while (command.ToLower() != "end")
            {
                if (command.ToLower() == "add")
                {
                    numbers.Push(int.Parse(commands[1]));
                    numbers.Push(int.Parse(commands[2]));
                }
                else if (command.ToLower() == "remove")
                {
                    for (int i = 0; i < int.Parse(commands[1]); i++)
                    {
                        numbers.Pop();
                    }
                }
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");

            // Second way to prints the sum

            /*int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"Sum: {sum}");*/
        }
    }
}
