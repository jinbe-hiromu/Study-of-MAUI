namespace MauiTestApp;

public partial class BrowserPage : ContentPage
{
	public BrowserPage()
	{
		InitializeComponent();
	}

	private async void OnOpenWebBrowserClicked(object sender, EventArgs e)
	{
		await Browser.OpenAsync("https://www.youtube.com/");
	}
}