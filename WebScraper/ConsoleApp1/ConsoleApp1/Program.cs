using System;
using System.Net.Http;

namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                string url = "";
                HttpClient client = new HttpClient();

                while (!CheckUrl(url, client))
                {
                    Console.WriteLine("Write the website you would want to scrape");
                    url = Console.ReadLine();
                    if (!url.Contains("http"))
                    {
                        url = "http://" + url;
                    }
                    if (url == "exit" || url == "quit")
                    {
                        quit = true;
                        break;
                    }
                }

                if (quit == false)
                {
                    Scrape(url, client);
                }

            }
        }

        public static void Scrape(string url,HttpClient client)
        {
            var html = client.GetStringAsync(url);
            html.Wait();
            Console.WriteLine(html.Result);
        }

        public static bool CheckUrl(string url,HttpClient client)
        {
            try
            {
                var html = client.GetStringAsync(url);
            }
            catch 
            {
                return false;
            }
            return true;
        }
    }
}
