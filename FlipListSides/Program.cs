using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            //2 3 4 1 
            for (int i = 1; i < numbers.Count / 2; i++)
            {
                int prev = numbers[i];
                numbers[i] = numbers[numbers.Count - i - 1];
                numbers[numbers.Count - i - 1] = prev;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
