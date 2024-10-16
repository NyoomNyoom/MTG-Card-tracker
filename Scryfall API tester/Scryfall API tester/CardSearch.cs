using Scryfall_API_tester;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Web;

namespace Scryfall_API_tester;

public class CardSearch
{
    public async Task<ResultModel> SearchScryfall(string searchTerm = null)
    {
        string url;

        if (!string.IsNullOrEmpty(searchTerm))
        {
            string encodedSearch = HttpUtility.UrlEncode(searchTerm);
            url = $"https://api.scryfall.com/cards/search?order=cmc&q={encodedSearch}";
        }
        else
        {
            url = "https://api.scryfall.com/cards/search?order=cmc";
        }

        using (HttpResponseMessage response = await APIHandler.APIClient.GetAsync(url))
        {
            if (response.IsSuccessStatusCode)
            {
                // Output the raw content to the console to check for errors
                string rawContent = await response.Content.ReadAsStringAsync();
                Debug.WriteLine("Raw Response: " + rawContent); // For debugging purposes

                try
                {
                    // Attempt to deserialize the response to ResultModel
                    ResultModel searchResults = await response.Content.ReadFromJsonAsync<ResultModel>();
                    return searchResults;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Deserialization Error: " + ex.Message);
                    throw;  // Re-throw to see the error at the source level
                }
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }
    }
}
