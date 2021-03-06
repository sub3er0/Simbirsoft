﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simbirsoft
{
    class Algorithm
    {
        public static Dictionary<String, int> Words { get; set; }
        public static void SplitText()
        {
            Words = new Dictionary<string, int>();
            using (StreamReader sr = new StreamReader("htmlPage.html", System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    String[] splittedWords = line.Split(new Char[] {' ', ',', '.', '!', '?',
                    '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t'});
                    foreach (String word in splittedWords)
                    {
                        if (Words.ContainsKey(word))
                            Words[word] = Words[word] + 1;
                        else
                            Words.Add(word, 1);
                    }
                }
                //foreach (var w in Words)
                //    Console.WriteLine($"{w.Key} - {w.Value}");
            }

        }
    }
}
