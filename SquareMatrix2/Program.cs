using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareMatrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[0];
            char[][] matrix = new char[rows][];
            int squaresCounter = 0;

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            }

            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j <= cols-1; j++)
                {
                    Console.WriteLine(matrix[i][j]);
                    int current = matrix[i][j];
                    if (current == matrix[i][j+1] && current == matrix[i+1][j] && current == matrix[i + 1][j+1])
                    {
                        squaresCounter++;
                    }
                }
            }
            Console.WriteLine(squaresCounter);
        }
    }
}
