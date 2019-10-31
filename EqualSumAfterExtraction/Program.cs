using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> resultList = new List<int>();

            for (int i = 0; i < secondList.Count; i++)
            {
                if(!firstList.Contains(secondList[i]))
                {
                    resultList.Add(secondList[i]);
                }
            }
            int sumFirst = firstList.Sum();
            int sumResultList = resultList.Sum();

            if(sumFirst == sumResultList)
            {
                Console.WriteLine("Yes. Sum: {0}", sumFirst);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(sumFirst-sumResultList));
            }
        }
    }
}
