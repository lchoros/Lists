using System;
using System.Collections.Generic;
using System.Linq;

namespace Camel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int m = int.Parse(Console.ReadLine());

            int round = 0;
            if (numbers.Count == m)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", numbers));
            }
            else
            {
                while(numbers.Count != m)
                {
                    numbers.RemoveAt(0);
                    numbers.RemoveAt(numbers.Count-1);
                    round++;
                }
                Console.WriteLine("{0} rounds", round);
                Console.WriteLine("remaining: {0}", string.Join(" ", numbers));
            }
        }
    }
}
