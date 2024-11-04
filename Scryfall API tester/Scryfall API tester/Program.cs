using NetSpell.SpellChecker.Dictionary;
using Scryfall_API_tester;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

class Program
{
    /*
    public class DicResponse
    {
        public string word { get; set; }
    }

    public static async Task SearchDictionary()
    {
        string url = "https://api.dictionaryapi.dev/api/v2/entries/en/hello"; // Example URL
        using (HttpResponseMessage APIresponse = await APIHandler.APIClient.GetAsync(url))
        {
            if (APIresponse.IsSuccessStatusCode)
            {
                string jsonString = await APIresponse.Content.ReadAsStringAsync();

                // Deserialize the response into ScryfallResponse object
                DicResponse results = JsonSerializer.Deserialize<DicResponse>(jsonString);

                Console.WriteLine(results.word);

            }
            else
            {
                throw new Exception($"API Error: {APIresponse.StatusCode} - {APIresponse.ReasonPhrase}");
            }
        }
    }
    */
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        APIHandler.InitialiseClient();
        CardSearch search = new();

        // Await the search result
        await search.SearchScryfall();

        // Process or display the results
        Console.WriteLine("Search completed!");
        // You can now access 'results' and process the data

        //Console.WriteLine(results.Object);


        //await SearchDictionary();
    }
}