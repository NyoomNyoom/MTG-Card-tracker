using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;
using MtgApiManager.Lib.Service;

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

        foreach (var card in apiResult)
        {
            if (card != null)
            {
                if (card.Name != null)
                {
                    IOperationResult<List<ICard>> tempResult = service.Where(x => x.Name, card.Name).AllAsync().Result;

                    if (tempResult.IsSuccess && tempResult.Value.First().MultiverseId != null)
                    {
                        searchImage.Source = ImageSource.FromUri(tempResult.Value.First().ImageUrl);
                        searchResults.Text = card.Name;
                    }
                }
            }
        }


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