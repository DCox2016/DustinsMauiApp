namespace DustinsMauiApp.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void LearnMore_Github(object sender, EventArgs e)
	{
		if (BindingContext is Models.AboutPage about)
		{
			await Launcher.Default.OpenAsync(about.GitHub);
		}
	}

    private async void LearnMore_LinkedIn(object sender, EventArgs e)
    {
        if (BindingContext is Models.AboutPage about)
        {
            await Launcher.Default.OpenAsync(about.LinkedIn);
        }
    }
}