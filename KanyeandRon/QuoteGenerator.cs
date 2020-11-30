using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeandRon
{
    public class QuoteGenerator
    {

        private HttpClient _client;

        public QuoteGenerator(HttpClient client)
        {
            _client = client;
        }

        public string Kanye()
        {
            //API Url
            var kanyeURL = "https://api.kanye.rest";

            //Stores the JSON repsonse in a variable
            var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;

            //Parses through the response we received to get the value associated with
            //the NAME "quote"
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public string RonSwanson()
        {
            //Ron Swanson URL
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = _client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse);

            return ronQuote[0].ToString();
        }
    }
}
