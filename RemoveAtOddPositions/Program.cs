﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                if(i % 2 != 0)
                {
                    result.Add(words[i]);
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
