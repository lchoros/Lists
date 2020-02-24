using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] tokens = command.Split(' ');
                switch (tokens[0])
                {
                    case "add":
                        int index = int.Parse(tokens[1]);
                        int num = int.Parse(tokens[2]);
                        numbers.Insert(index, num);
                        break;
                    case "addMany":
                        int index2 = int.Parse(tokens[1]);
                        numbers.InsertRange(int.Parse(tokens[1]), tokens.Skip(2).Select(int.Parse).ToList());
                        break;
                    case "contains":
                        Console.WriteLine(numbers.IndexOf(int.Parse(tokens[1])));
                        break;
                    case "remove":
                        numbers.RemoveAt(int.Parse(tokens[1]));
                        break;
                    case "shift":
                        int position = int.Parse(tokens[1]);
                        List<int> 
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
