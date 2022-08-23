namespace MauiTestApp;

public partial class SliderPage : ContentPage
{
	public SliderPage()
	{
		InitializeComponent();
	}

	private void ChangeSlider(object sender, ValueChangedEventArgs e)
	{
		var constant = 300;
		var height = constant * slider.Value / slider.Maximum;
        var width = constant * slider.Value / slider.Maximum;

        img.HeightRequest = height;
		img.WidthRequest = width;
	}
}