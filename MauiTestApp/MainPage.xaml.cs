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

    private void OnGoToScreenTransitionClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ScreenTransitionPage());
    }

    private void OnGoToDialogClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new DialogPage());
    }

    private void OnGoToBlueToothClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BlueTooth());
    }

    private void OnGoToWebApiClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WebApiPage());
    }

    private void OnGoToWebApiLambdaClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WebApiLambda());
    }

    private void OnGoToCalenderClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CalenderPage());
    }

    private void OnGoToBrowserClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BrowserPage());
    }

    private void OnGoToAccelerometerClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AccelerometerPage());
    }

    private void OnGoToGpsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GpsPage());
    }
}

