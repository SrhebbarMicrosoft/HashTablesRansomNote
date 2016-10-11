using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesRansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int m = int.Parse(tokens[0]);
            int n = int.Parse(tokens[1]);
            string[] magazine = Console.ReadLine().Split();
            string[] ransomNote = Console.ReadLine().Split();
            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach(string word in magazine)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words.Add(word, 1);
                }
            }

            foreach(string word in ransomNote)
            {
                if (words.ContainsKey(word))
                {
                    words[word]--;
                    if (words[word] == -1)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
