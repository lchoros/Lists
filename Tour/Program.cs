﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] distances = new int[size][];

            for (int i = 0; i < size; i++) 
            {
                distances[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            int[] cities = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int distance = 0;
            int currentCity = 0;

            for (int i = 0; i < cities.Length; i++)
            {

            }

        }
    }
}
