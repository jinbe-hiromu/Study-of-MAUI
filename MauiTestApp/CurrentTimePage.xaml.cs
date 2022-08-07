namespace MauiTestApp;

public partial class CurrentTimePage : ContentPage
{
	public CurrentTimePage()
	{
		InitializeComponent();
	}

	private void OnShowNowTimeClicked(object sender, EventArgs e)
	{
		labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
	}

	private void OnGoBackClicked(object sender, EventArgs eventArgs)
	{
		Navigation.PopAsync();
	}
}