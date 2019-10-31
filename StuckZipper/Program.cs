using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckZipper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        }
    }
}
