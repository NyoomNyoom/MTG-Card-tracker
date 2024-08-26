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

		if (count == 1)
			CounterBtn.Text = $"Clicked {card.GetName()} time";
		else
			CounterBtn.Text = $"Clicked {card.GetName()} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

