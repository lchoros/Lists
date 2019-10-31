using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] occurrences = new int[1000];

            for (int i = 0; i < numbers.Count; i++)
            {
                occurrences[numbers[i]] += 1;
            }

            for (int i = 0; i < occurrences.Length; i++)
            {
                if(occurrences[i] > 0)
                {
                    Console.WriteLine("{0} -> {1}", i, occurrences[i]);
                }
            }
        }
    }
}
