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
            while(command != "print")
            {
                string[] tokens = command.Split(' ');
                string action = tokens[0];
                switch (action)
                {
                    case "add":
                        int index = int.Parse(tokens[1]);
                        int element = int.Parse(tokens[2]);
                        numbers.Insert(index, element);
                        break;
                    case "addMany":
                        int index2 = int.Parse(tokens[1]);
                        int[] elements = tokens.Skip(2).Select(int.Parse).ToArray();
                        numbers.InsertRange(index2, elements);
                        break;
                    case "contains":
                        int element2 = int.Parse(tokens[1]);
                        Console.WriteLine(numbers.IndexOf(element2));
                        break;
                    case "remove":
                        int index3 = int.Parse(tokens[1]);
                        numbers.RemoveAt(index3);
                        break;
                    case "shift":
                        int positions = int.Parse(tokens[1]);
                        for (int i = 0; i < positions; i++)
                        {
                            numbers.Insert(numbers.Count, numbers[0]);
                            numbers.RemoveAt(0);

                            //int lastElement = numbers[0];
                            //for (int j = 0; j < numbers.Count - 1; j++)
                            //{
                            //    numbers[j] = numbers[j + 1];
                            //}
                            //numbers[numbers.Count - 1] = lastElement;
                        }
                        break;
                    case "sumPairs":
                        List<int> newList = new List<int>();
                        for (int i = 0; i < numbers.Count - 1; i += 2)
                        {
                            newList.Add(numbers[i] + numbers[i + 1]);
                        }
                        if (numbers.Count % 2 == 1)
                        {
                            newList.Add(numbers[numbers.Count - 1]);
                        }
                        numbers = newList;
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
