namespace MauiTestApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnNextClicked(object sender,EventArgs e)
	{
		Navigation.PushAsync(new NewPage1());
	}

    private void OnGoToCurrentTimePageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CurrentTimePage());
    }

    private void OnGoToDataListsPageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new DataLists());
    }

    private void OnGoToTextPageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TextPage());
    }
}

