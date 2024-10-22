using Scryfall_API_tester;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class CardSearch
{
    public async Task SearchScryfall()
    {
        string url = "https://api.scryfall.com/cards/search?q=black"; // Example URL
        using (HttpResponseMessage response = await APIHandler.APIClient.GetAsync(url))
        {
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();

                // Deserialize the response into ScryfallResponse object
                ScryfallResponse scryfallResponse = JsonSerializer.Deserialize<ScryfallResponse>(jsonString);

                // Iterate over each card in the data list
                foreach (Card card in scryfallResponse.data)
                {
                    Console.WriteLine($"Card Name: {card.name}");
                    Console.WriteLine($"Type: {card.type_line}");
                    Console.WriteLine($"Power/Toughness: {card.power}/{card.toughness}");
                    Console.WriteLine($"Price (USD): {card.prices.usd}");
                    Console.WriteLine($"Image URL: {card.image_uris.normal}");
                    Console.WriteLine("-------------------------------");
                }

                // If there's more data (pagination), handle next_page
                if (scryfallResponse.has_more)
                {
                    Console.WriteLine($"More cards available at: {scryfallResponse.next_page}");
                }
            }
            else
            {
                throw new Exception($"API Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }
    }
}
