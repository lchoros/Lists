using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];
            int counter = 'A';
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new char[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = (char)(counter++);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
