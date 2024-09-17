using MtgApiManager.Lib.Service;

namespace MTG_Card_tracker;

public partial class CollectionPage : ContentPage
{
	private string searchResults = null;

    IMtgServiceProvider serviceProvider = new MtgServiceProvider();

    public CollectionPage()
	{
		InitializeComponent();
	}

    private void SearchButton_Clicked(object sender, EventArgs e)
    {

    }
}