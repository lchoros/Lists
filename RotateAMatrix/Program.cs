using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[][] matrix = new string[rows][];
            string[][] result = new string[cols][];

            for (int i = 0; i < cols; i++)
            {
                result[i] = new string[rows];
            }
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ');
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[rows-1-i][i] = matrix[i][j];
                }
            }
            //for (int i = 0; i < cols; i++)
            //{
            //    Console.WriteLine(string.Join(" ", result[i]));
            //}
        }
    }
}
