using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scryfall_API_tester
{
    public static class APIHandler
    {
        public static HttpClient? APIClient { get; set; }
        
        public static void InitialiseClient()
        {
            APIClient = new HttpClient();
            APIClient.DefaultRequestHeaders.Accept.Clear();
        }
    }
}
