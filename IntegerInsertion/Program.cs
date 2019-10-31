using System;
using System.Collections.Generic;
using System.Linq;

namespace IntegerInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while(command != "end")
            {
                int num = int.Parse(command);
                while (num >= 10)
                {
                    num = num / 10;
                }
                numbers.Insert(num, int.Parse(command));
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
