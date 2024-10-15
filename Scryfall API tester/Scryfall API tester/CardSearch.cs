using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Scryfall_API_tester
{
    public class CardSearch
    {
        public async Task<ResultModel> SearchScryfall(string searchTerm = null)
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

            using (HttpResponseMessage response = await APIHandler.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ResultModel SearchResults = await response.Content.ReadFromJsonAsync<ResultModel>;

                    return SearchResults;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
