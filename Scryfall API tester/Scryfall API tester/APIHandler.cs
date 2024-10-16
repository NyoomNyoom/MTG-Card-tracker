using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Scryfall_API_tester
{
    public static class APIHandler
    {
        public static HttpClient APIClient { get; set; }

        public static void InitialiseClient()
        {
            APIClient = new HttpClient();
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            APIClient.DefaultRequestHeaders.UserAgent.ParseAdd("MTGCardTracker/1.0");
        }
    }
}