namespace MauiTestApp;

public partial class CalenderPage : ContentPage
{
	public CalenderPage()
	{
		InitializeComponent();
	}

	private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
	{
		text.Text = datePicker.Date.ToString("yyyy”NMMŒŽdd“ú");
	}
}