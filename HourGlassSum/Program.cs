using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourGlassSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            int maxSum = int.MinValue;
            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix.Length - 2; col++)
                {
                    int currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] + matrix[row + 1][col + 1] +
                        matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
