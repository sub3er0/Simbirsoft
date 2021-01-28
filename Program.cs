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
            String url = Console.ReadLine();
            while (FileWorker.Download(url) == false)
            {
                url = Console.ReadLine();
            }
            Algorithm.SplitText();
            foreach (var w in Algorithm.Words)
                Console.WriteLine($"{w.Key} - {w.Value}");

            Console.ReadLine();
        }
    }
}
