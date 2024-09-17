namespace MTG_Card_tracker;


public partial class MainPage : ContentPage
{
	int count = 0;

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
}

