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
            int bestStart = 0;
            int longestSequence = 1;
            int start = 0;
            int seqLen = 1;
            for (int i = 1; i < numbers.Count-1; i++)
            {
                if(numbers[i] == numbers[i-1])
                {
                    seqLen++;
                    if(seqLen > longestSequence)
                    {
                        longestSequence = seqLen;
                        bestStart = start;
                    }
                }
                else
                {
                    seqLen = 1;
                    start = i;
                }
            }
            Console.WriteLine(string.Join(" ", numbers.Skip(bestStart).Take(longestSequence)));
        }
    }
}
