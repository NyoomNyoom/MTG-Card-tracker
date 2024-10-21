using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
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
            }
            else
            {
                url = HttpUtility.UrlEncode("https://api.scryfall.com/cards/search?order=cmc");
            }

            using (HttpResponseMessage response = await ScryfallAPIHandler.ScryFallClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    //SearchResultModel SearchResults = await response.Content.ReadAsAsync<SearchResultModel>();
                    string jsonString = await response.Content.ReadAsStringAsync();

                    ScryfallResponse  scryfallResponse = JsonSerializer.Deserialize<ScryfallResponse>(jsonString);

                    foreach (Card card in scryfallResponse.data)
                    {
                        Console.WriteLine($"Card Name: {card.GetName}");
                    }

                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }          
            }
        }
    }
}
