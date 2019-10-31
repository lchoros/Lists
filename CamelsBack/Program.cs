using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelsBack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int m = int.Parse(Console.ReadLine());

            int round = 0;
            if(numbers.Count == m)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", numbers));
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {

                    round++;
                    if(numbers.Count == m)
                    {
                        break;
                    }
                }
            }

        }
    }
}
