using Microsoft.Maui.Layouts;
using System.Xml.Schema;

namespace MTG_Card_tracker;

public partial class TrackerPage : ContentPage
{
	private int p1HP = 40;
	private int p2HP = 40;
	private int p3HP = 40;
	private int p4HP = 40;

	public TrackerPage()
	{
		InitializeComponent();
	}

	private void AddHP_p1(object sender, EventArgs e)
	{
		p1HP++;
		UpdateHP();
	}

    private void LoseHP_p1(object sender, EventArgs e)
    {
        p1HP--;
		UpdateHP();
    }

	private void UpdateHP()
	{
		P1HealthCounter.Text = p1HP.ToString();
	}
}