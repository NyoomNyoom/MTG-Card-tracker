using Scryfall_API_tester;
using System.Threading.Tasks;
class Program
{
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
    }
}