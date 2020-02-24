using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPlaatform2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[][] matrix = new int[rows][];
            int highestSum = 0;
            int maxRow = 0;
            int maxCol = 0;
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            for (int i = 0; i < rows-2; i++)
            {
                for (int j = 0; j < cols-2; j++)
                {
                    int currentSum = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2] + matrix[i + 1][j] + matrix[i + 1][j+1] + matrix[i + 1][j + 2] +
                        + matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];
                    if(currentSum > highestSum)
                    {
                        highestSum = currentSum;
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }
            Console.WriteLine(highestSum);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[maxRow+i].Skip(maxCol)));
            }
        }
    }
}
