using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();

            int sum = 0;
            foreach (var number in numbers)
            {
                List<char> arr = number.ToList();
                arr.Reverse();
                sum += int.Parse(string.Join("", arr));
            }
            Console.WriteLine(sum);
        }
    }
}
