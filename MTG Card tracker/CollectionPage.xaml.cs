using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;
using MtgApiManager.Lib.Service;
using System.Diagnostics;

namespace MTG_Card_tracker;

public partial class CollectionPage : ContentPage
{

    readonly IMtgServiceProvider serviceProvider = new MtgServiceProvider();

    public CollectionPage()
	{
		InitializeComponent();
	}

    private async void SearchButton_Clicked(object sender, EventArgs e)
    {
        ICardService service = serviceProvider.GetCardService();
        //IOperationResult<List<ICard>> result = service.AllAsync().Result;
        IOperationResult<List<ICard>> result = service.Where(x => x.Name, "Archangel Avacyn").AllAsync().Result;
 
        var apiResult = result.Value.ToArray();

        result.Value.ForEach(x => { 
            Debug.WriteLine("Name: " + x.Name); 
            if (x.ImageUrl != null)
            {
                Debug.WriteLine("Image URL " + x.ImageUrl.ToString());
            }
            else
            {
                Debug.WriteLine("No Image uri");
            }
        });

        searchImage.Source = ImageSource.FromUri(new System.Uri("http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=409741&type=card"));
        searchResults.Text = "Hello!";
        
        /**
        foreach (var card in apiResult)
        {
            if (card != null)
            {
                if (card.Name != null)
                {
                    IOperationResult<List<ICard>> tempResult = service.Where(x => x.Name, card.Name).AllAsync().Result;

                    if (tempResult.IsSuccess)
                    {
                        searchImage.Source = ImageSource.FromUri(new System.Uri("http://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=409741&type=card"));
                        searchResults.Text = "Hello!";
                    }
                }
            }
        }
        **/

        /**
        var searchResult = result.Value.ToArray();

            foreach ( var card in searchResult )
            {
                if ( card != null )
                {
                    searchResults.Text = card.Name;
                    //searchImage.Source = ImageSource.FromUri();
                }
            }
        **/

    }
}