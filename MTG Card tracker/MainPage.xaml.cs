namespace MTG_Card_tracker;


public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Card card = new Card("Black lotus", "2");
		count++;
	}

    private async void Tracker_Clicked(object sender, EventArgs e)
    {
		// Navigation.PushAsync(new NavigationPage(new SecondPage()));
		await Navigation.PushAsync(new NavigationPage(new TrackerPage()));
    }
}

