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
            int size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];
            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                firstDiagonalSum += matrix[i][i];
                secondDiagonalSum += matrix[i][size-1-i];
            }
            Console.WriteLine(Math.Abs(firstDiagonalSum-secondDiagonalSum));
        }
    }
}
