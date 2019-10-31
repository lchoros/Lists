using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = ",;:.!()\"\'\\/[] ".ToCharArray();
            List<string> words = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixCase = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                string word = words[i];
                bool isLower = false;
                bool isUpper = false;
                bool isMix = false;
                for (int j = 0; j < word.Length; j++)
                {
                    if(word[j] >= 'a' && word[j] <= 'z')
                    {
                        isLower = true;
                    }
                    else if ((word[j] >= 'A' && word[j] <= 'Z'))
                    {
                        isUpper = true;
                    }
                    else
                    {
                        isMix = true;
                    }
                }

                if ((isUpper && isLower) || isMix)
                {
                    mixCase.Add(words[i]);
                }
                else if(isUpper)
                {
                    upperCase.Add(words[i]);
                }
                else
                {
                    lowerCase.Add(words[i]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixCase)}");

            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
