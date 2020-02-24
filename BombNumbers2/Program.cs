using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fields = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bombData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bomb = bombData[0];
            int power = bombData[1];
            int bombIndex = fields.IndexOf(bomb);

            while(bombIndex != -1)
            {
                int startIndex = bombIndex - power < 0 ? 0 : bombIndex-power;
                int endIndex = bombIndex + power > fields.Count - 1 ? fields.Count : bombIndex + power + 1;
                fields.RemoveRange(startIndex, endIndex - startIndex);
                bombIndex = fields.IndexOf(bomb);
            }
            Console.WriteLine(fields.Sum());
        }
    }
}
