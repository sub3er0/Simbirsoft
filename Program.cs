using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Simbirsoft
{
    class Program
    {
        static void Main(string[] args)
        {
            //String url = Console.ReadLine();
            //FileWorker.Download(url);

            Dictionary<String, int> words = new Dictionary<string, int>();
            using (StreamReader sr = new StreamReader("2.txt", System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    String[] splittedWords = line.Split(new Char[] {' ', ',', '.', '!', '?',
                    '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t'});
                    foreach (String word in splittedWords)
                    {
                        if (words.ContainsKey(word))
                            words[word] = words[word] + 1;
                        else
                            words.Add(word, 1);
                    }
                }
                foreach (var w in words)
                    Console.WriteLine($"{w.Key} - {w.Value}");
            }

            Console.ReadLine();
        }
    }
}
