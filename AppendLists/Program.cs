using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            char[] delimiter = " ".ToCharArray();
            List<string> lists = Console.ReadLine().Split('|').Reverse().ToList();
            for (int i = 0; i < lists.Count; i++)
            {
                List<string> numbers = lists[i].Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(numbers);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
