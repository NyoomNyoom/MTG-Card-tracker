namespace MTG_Card_tracker;


public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private async void Tracker_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new NavigationPage(new TrackerPage()));
    }

	private async void Collection_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new NavigationPage(new CollectionPage()));
	}

	private void Search_Completed(object sender, EventArgs e)
	{
		string query = ((Entry)sender).Text;

		SearchResults.Text = query;
	}
}

