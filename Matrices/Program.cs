using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            char type = char.Parse(tokens[0]);
            int rows = int.Parse(tokens[1]);
            int cols = int.Parse(tokens[2]);
            int[][] matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
            }

            switch (type)
            {
                //case 'A': PrintA(matrix, rows, cols); break;
                case 'B': PrintB(matrix, rows, cols); break;
                //case 'C': PrintC(matrix, rows, cols); break;
                //case 'D': PrintD(matrix, rows, cols); break;
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        static void PrintA(int[][] matrix, int rows, int cols)
        {
            int counter = 1;
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[row][col] = counter++;
                }
            }
        }

        static void PrintB(int[][] matrix, int rows, int cols)
        {
            int counter = 1;
            for (int col = 0; col < cols; col++)
            {
                int k = col % 2 == 0 ? 0 : matrix.Length - 1;
                for (int row = k; row < rows && row >= 0; row = k == 0 ? row + 1 : row -1)
                {
                        matrix[row][col] = counter++;
                }
            }
        }

        static void PrintC(int[][] matrix, int rows, int cols)
        {
            int counter = 1;

            for (int i = 0; i < cols; i++)
            {
                int k = i % 2 == 0 ? 0 : matrix.Length - 1;

                for (int j = k; j < cols && j >= 0; j = k == 0 ? j + 1 : j-1)
                {
                    matrix[j][i] = counter++;
                }

            }
        }
    }
}
