using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


            for (int i = 0; i < numbers.Count; i++)
            {
                List<int> tempNumbers = new List<int>();
                if (tempNumbers.Last().Equals(numbers[i]))
                {
                    tempNumbers
                }
                tempNumbers.Add(i);
            }
        }
    }
}
