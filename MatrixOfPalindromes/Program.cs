using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> size = Console.ReadLine().Split().Select(int.Parse).ToList();
            int rows = size[0];
            int cols = size[1];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(""+(char)('a' + i) + (char)('a' + i + j) + (char)('a' + i)+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
