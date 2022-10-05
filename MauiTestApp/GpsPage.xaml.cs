namespace MauiTestApp;

public partial class GpsPage : ContentPage
{
	public GpsPage()
	{
		InitializeComponent();
	}

    private async void OnClicked(object sender, EventArgs e)
    {
        var location = await Geolocation.GetLocationAsync();
        labelLatitude.Text = $"�ܓx: {location.Latitude:0.000}";
        labelLongitude.Text = $"�o�x: {location.Longitude:0.000}";
        labelAltitude.Text = $"���x: {location.Altitude:0.000}";
    }
}