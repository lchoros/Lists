using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];
            int distance = 0;
            int currentCity = 0;
            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            }

            int[] cities = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < cities.Length; i++)
            {
                int destination = cities[i];
                distance += matrix[currentCity][destination];
                currentCity = destination;
            }
            Console.WriteLine(distance);
        }
    }
}
