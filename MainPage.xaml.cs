namespace Hampter;

public partial class MainPage : ContentPage
{
    int revive = 1;
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        if (HampterBtn.Source.ToString() == "File: hampter.png")
		{
            count++;

            if (count == 1)
                label.Text = $"Bonked hampter {count} time";
            else
                label.Text = $"Bonked hampter {count} times";

            SemanticScreenReader.Announce(label.Text);

            HampterBtn.Scale += 0.5;

            if (count >= 17)
            {
                HampterBtn.Source = "bumbum.png";
                HampterBtn.ScaleTo(1, 500);
                HampterText.Text = "Oh no you killed hampter!";
                revive *= 2;
                count = revive;
                label.Text = $"Click {count} times to revive hampter";
            }

        }
        else
        {
            count--;

            if (count == 1)
                label.Text = $"Click once to revive hampter";
            else
                label.Text = $"Click {count} times to revive hampter";

            if (count == 0)
            {
                HampterBtn.Source = "hampter.png";
                HampterText.Text = "Feed the hampter!";
                label.Text = $"Bonked hampter {count} times";
            }
        }
	}
}

