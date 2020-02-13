using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string[] commands = Console.ReadLine().Split(' ').ToArray();

            string command = commands[0];

            while(command != "print")
            {
                if(command == "add")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    

                }
                else if (command == "addMany")
                {
                    int[] nums = commands.Skip(1).Select(int.Parse).ToArray();

                }
                else if (command == "contains")
                {
                    int number = int.Parse(commands[1]);
                    if(numbers.Contains(number))
                    {
                        Cons
                    }
                }
                else if (command == "remove")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                }
                else if (command == "shift")
                {
                    int shift = int.Parse(commands[1]);
                }
                else if(command == "sumPairs")
                {

                }
                commands = Console.ReadLine().Split(' ').ToArray();
                command = commands[0];
            }
        }
    }
}
