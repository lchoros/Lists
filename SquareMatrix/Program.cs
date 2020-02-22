using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int rows = input[0];
            int cols = input[1];
            int counter = 0;
            List<char> lines = new List<char>();
            List<List<char>> list2d = new List<List<char>>();
            for (int i = 0; i < rows; i++)
            {
                list2d.Add(Console.ReadLine().Split(' ').Select(char.Parse).ToList()) ;
            }

            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    if (list2d[i][j] == list2d[i][j + 1] && list2d[i][j] == list2d[i+1][j] && list2d[i][j] == list2d[i + 1][j+1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
