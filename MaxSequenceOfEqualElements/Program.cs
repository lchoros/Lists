using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int start = 0;
            int length = 1;
            int currentStart = 0;
            int currentLength = 1;
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if(numbers[i] == numbers[i+1])
                {
                    currentLength++;
                    if (currentLength > length)
                    {
                        length = currentLength;
                        start = currentStart;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentStart = i + 1;
                }
            }

            List<int> result = numbers.Skip(start).Take(length).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
