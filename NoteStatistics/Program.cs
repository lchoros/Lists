using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            Dictionary<decimal, string> pairs = new Dictionary<decimal, string>()
            {
                { 261.63m, "C" },
                { 277.18m, "C#" },
                { 293.66m, "D" },
                { 311.13m, "D#" },
                { 329.63m, "E" },
                { 349.23m, "F" },
                { 369.99m, "F#" },
                { 392.00m, "G" },
                { 415.30m, "G#" },
                { 440.00m, "A" },
                { 466.16m, "A#" },
                { 493.88m, "B" }
            };

            List<string> sharp = new List<string>();
            List<string> naturals = new List<string>();
            List<string> notes = new List<string>();
            decimal sharpSum = 0m;
            decimal naturalSum = 0m;

            for (int i = 0; i < input.Count; i++)
            {
                if (pairs[input[i]].EndsWith("#"))
                {
                    sharp.Add(pairs[input[i]]);
                    notes.Add(pairs[input[i]]);
                    sharpSum += input[i];
                }
                else
                {
                    naturals.Add(pairs[input[i]]);
                    notes.Add(pairs[input[i]]);
                    naturalSum += input[i];
                }
            }
            Console.WriteLine("Notes: {0}", string.Join(" ", notes));
            Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharp));
            Console.WriteLine("Naturals sum: {0:G29}", naturalSum);
            Console.WriteLine("Sharps sum: {0:G29}", sharpSum);
            Console.Beep(1220, 120);
            Console.Beep(432, 120);
            Console.Beep(111, 12000);
            Console.Beep(123, 12000);
        }
    }
}