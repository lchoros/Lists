using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                result.Add(numbers[numbers.Count / 2 + i] / 10);
                result.Add(numbers[i]);
                result.Add(numbers[numbers.Count / 2 + i] % 10);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
