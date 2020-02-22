using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices2
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
                //case 'A': A(matrix, rows, cols); break;
                case 'B': B(matrix, rows, cols); break;
                //case 'C': C(matrix, rows, cols); break;
                //case 'D': D(matrix, rows, cols); break;
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }



        static void B(int[][] matrix, int rows, int cols)
        {
            int counter = 1;

            for (int i = 0; i < cols; i++)
            {
                int k = i % 2 == 0 ? 0 : matrix.Length - 1;
                for (int j = k; j >= 0 && j < matrix.Length; j = k == 0 ? j+1 : j-1)
                {
                    matrix[j][i] = counter++;
                }
                //if (i % 2 == 0)
                //{
                //    for (int j = 0; j < matrix.Length; j++)
                //    {
                //        matrix[j][i] = counter++;
                //    }
                //}
                //else
                //{
                //    for (int j = cols-1; j >= 0; j--)
                //    {
                //        matrix[j][i] = counter++;
                //    }
                //}
            }
        }
    }
}
