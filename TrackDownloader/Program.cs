using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> blacklistedWords = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();
            string filename = Console.ReadLine();

            while(filename != "end")
            {
                bool isBlacklisted = false;
                for (int i = 0; i < blacklistedWords.Count; i++)
                {
                    if(filename.Contains(blacklistedWords[i]))
                    {
                        isBlacklisted = true;
                        break;
                    }
                }
                if(!isBlacklisted)
                {
                    result.Add(filename);
                }
                filename = Console.ReadLine();
            }
            result.Sort();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
