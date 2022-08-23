namespace MauiTestApp;

public partial class SwitchPage : ContentPage
{
	public SwitchPage()
	{
		InitializeComponent();
		sw.IsToggled = true;
	}

	private void ChangeToggle(object sender, ToggledEventArgs e)
	{
        img.IsVisible = sw.IsToggled;
	}
}