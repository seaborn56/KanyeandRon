using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeandRon
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Kanye: {quote.Kanye()}");

                Console.WriteLine($"Ron Swanson: {quote.RonSwanson()}");

            }
        }
    }
}