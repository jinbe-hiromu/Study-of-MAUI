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

    private void OnGoToImagePageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ImagePage());
    }

    private void OnGoToFontPageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FontPage());
    }

    private void OnGoToMarginPageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MarginPage());
    }

    private void OnGoToListPageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListPage());
    }

    private void OnGoToSwitchPageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SwitchPage());
    }

    private void OnGoToSliderPageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SliderPage());
    }

    private void OnGoToKeyboardPageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new KeyboardPage());
    }
}

