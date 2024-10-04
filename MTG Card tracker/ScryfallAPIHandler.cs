using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MTG_Card_tracker
{
    public static class ScryfallAPIHandler
    {
        public static HttpClient ScryFallClient { get; set; }

        public static void InitialiseClient()
        {
            ScryFallClient = new HttpClient();
            ScryFallClient.DefaultRequestHeaders.Accept.Clear();
            ScryFallClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


    }
}
