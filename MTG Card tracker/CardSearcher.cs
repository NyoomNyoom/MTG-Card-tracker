using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MTG_Card_tracker
{
    public class CardSearcher
    {
        public async Task<SearchResultModel> SearchScryfall(string searchTerm = null)
        {
            string url;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string encodedSearch = HttpUtility.UrlEncode(searchTerm);
                url = $"https://api.scryfall.com/cards/search?order=cmc&q={encodedSearch}";
                Debug.WriteLine("if: True");
            }
            else
            {
                url = HttpUtility.UrlEncode("https://api.scryfall.com/cards/search?order=cmc");
                Debug.WriteLine("if: False");
            }

            using (HttpResponseMessage response = await ScryfallAPIHandler.ScryFallClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    SearchResultModel SearchResults = await response.Content.ReadAsAsync<SearchResultModel>();

                    return SearchResults;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }          
            }
        }
    }
}
