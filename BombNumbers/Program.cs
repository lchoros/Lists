using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> field = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //int[] bombData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int bomb = bombData[0];
            //int bombPower = bombData[1];

            //int bombIndex = field.IndexOf(bomb);

            //while(bombIndex != -1)
            //{
            //    List<int> resultField = new List<int>();
            //    resultField.AddRange(field.Take(bombIndex - bombPower).ToList());
            //    int firstBombedIndex = bombIndex - bombPower;
            //    if(firstBombedIndex < 0)
            //    {
            //        resultField.Skip(bombIndex+1+bombPower)
            //    }


            //    //if (bombIndex + bombPower > field.Count -1)
            //    //{
            //    //    field.RemoveRange(bombIndex+1, bombIndex+bombPower+1-field.Count);
            //    //}
            //    //else
            //    //{
            //    //    field.RemoveRange(bombIndex+1, bombPower);
            //    //}

            //    field = resultField;
            //    bombIndex = field.IndexOf(bomb);
            //}

            //Console.WriteLine(field.Sum());
            var result = 8 / 2 * (2 + 2);
            Console.WriteLine(result);
        }
    }
}
