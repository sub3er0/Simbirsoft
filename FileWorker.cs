using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Simbirsoft
{
    class FileWorker
    {
        public static bool Download(string url)
        {
            try
            {
                WebClient client = new WebClient();
                client.DownloadFile(url, "htmlPage.html");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Адрес введен некорректно.");
                return false;
            }            
        }
    }
}
