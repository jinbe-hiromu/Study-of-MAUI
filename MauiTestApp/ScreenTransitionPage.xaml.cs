namespace MauiTestApp;

public partial class ScreenTransitionPage : ContentPage
{
	public ScreenTransitionPage()
	{
		InitializeComponent();
	}

	private async void GoToPrevPageClicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}