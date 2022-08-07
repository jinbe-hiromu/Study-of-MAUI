namespace MauiTestApp;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

	private void OnPrevClicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}