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

    private void AddHP_p2(object sender, EventArgs e)
    {
        p2HP++;
        UpdateHP();
    }

    private void LoseHP_p2(object sender, EventArgs e)
    {
        p2HP--;
        UpdateHP();
    }

    private void AddHP_p3(object sender, EventArgs e)
    {
        p3HP++;
        UpdateHP();
    }

    private void LoseHP_p3(object sender, EventArgs e)
    {
        p3HP--;
        UpdateHP();
    }

    private void AddHP_p4(object sender, EventArgs e)
    {
        p4HP++;
        UpdateHP();
    }

    private void LoseHP_p4(object sender, EventArgs e)
    {
        p4HP--;
        UpdateHP();
    }

    private void UpdateHP()
	{
		P1HealthCounter.Text = p1HP.ToString();
        P2HealthCounter.Text = p2HP.ToString();
        P3HealthCounter.Text = p3HP.ToString();
        P4HealthCounter.Text = p4HP.ToString();
	}
}