using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int rows = input[0];
            int cols = input[1];
            List<List<int>> lines = new List<List<int>>();
            List<int> highestMatrix = new List<int>();
            int result = 0;
            for (int i = 0; i < rows; i++)
            {
                lines.Add(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            }
            for (int row = 0; row < rows-2; row++)
            {
                for (int col = 0; col < cols-2; col++)
                {
                    int currentHighest = 0;
                    List<int> matrix = new List<int>();
                    matrix.Add(lines[row][col]);
                    matrix.Add(lines[row][col + 1]);
                    matrix.Add(lines[row][col + 2]);
                    matrix.Add(lines[row + 1][col]);
                    matrix.Add(lines[row + 1][col + 1]);
                    matrix.Add(lines[row + 1][col + 2]);
                    matrix.Add(lines[row + 2][col]);
                    matrix.Add(lines[row + 2][col + 1]);
                    matrix.Add(lines[row + 2][col + 2]);
                    currentHighest += lines[row][col] + lines[row][col+1] + lines[row][col + 2] + lines[row+1][col] + lines[row+1][col + 1] + lines[row + 1][col + 2] +
                        lines[row + 2][col] + lines[row + 2][col + 1] + lines[row + 2][col + 2];
                    if (currentHighest > result)
                    {
                        result = currentHighest;
                        highestMatrix = matrix;
                    }
                }
            }
            Console.WriteLine(result);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(string.Join(" ", highestMatrix.Skip(i * 3).Take(3)));
            }
        }
    }
}