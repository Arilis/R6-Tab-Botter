using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace R6_Tab_Botter
{
    class Program
    {
        static void Main(string[] args)
        {
            String uuid;
            int sentBots = 0;
            String start;
            String url;

            Console.Title = "R6 Tab Profile View Botter | Made by ArilisDev | UUID: N/A | Bots: N/A";
            Console.Write("What is your R6 Tab UUID (Found in link of profile): ");
            uuid = Console.ReadLine();
            Console.WriteLine($"UUID Set: {uuid}");
            Console.Title = $"R6 Tab Profile View Botter | Made by ArilisDev | UUID: {uuid} | Bots: N/A";
            Console.Write("Write, 'Start' to start the botting: ");
            start = Console.ReadLine();
            if (start != "Start")
            {
                Console.WriteLine("Invalid Input, Quiting...");
                Thread.Sleep(2000);
                Process.GetCurrentProcess().Kill();
            } else
            {
                url = $"https://r6tab.com/mainpage.php?page=/{uuid}";
                while (true)
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    request.AutomaticDecompression = DecompressionMethods.GZip;
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse());

                    sentBots = sentBots + 1;
                    Console.Title = $"R6 Tab Profile View Botter | Made by ArilisDev | UUID: {uuid} | Bots: {sentBots}";
                    Console.WriteLine($"[{sentBots}]: Bot Successfully Sent.");
                }
            }

            Console.ReadLine();
        }
    }
}
