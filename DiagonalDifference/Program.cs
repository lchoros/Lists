using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            List<int> line = new List<int>();
            for (int i = 0; i < matrixSize; i++)
            {
                line = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                primaryDiagonal += line[i];
                secondaryDiagonal += line[matrixSize - 1 - i];
            }
            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
