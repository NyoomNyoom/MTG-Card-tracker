using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;
using MtgApiManager.Lib.Service;

namespace MTG_Card_tracker;

public partial class CollectionPage : ContentPage
{

    IMtgServiceProvider serviceProvider = new MtgServiceProvider();

    public CollectionPage()
	{
		InitializeComponent();
	}

    private async void SearchButton_Clicked(object sender, EventArgs e)
    {
        ICardService service = serviceProvider.GetCardService();
        IOperationResult<List<ICard>> result = service.AllAsync().Result;

        var searchResult = result.Value.ToArray();

        foreach ( var card in searchResult )
        {
            if ( card != null )
            {
                searchResults.Text = card.Name;
            }
        }

    }
}