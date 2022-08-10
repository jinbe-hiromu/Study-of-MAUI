namespace MauiTestApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	//private void OnCounterClicked(object sender, EventArgs e)
	//{
	//	count++;

	//	if (count == 1)
	//		CounterBtn.Text = $"Clicked {count} time";
	//	else
	//		CounterBtn.Text = $"Clicked {count} times";

	//	SemanticScreenReader.Announce(CounterBtn.Text);
	//}

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
}

