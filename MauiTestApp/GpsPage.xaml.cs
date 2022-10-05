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
        labelLatitude.Text = $"緯度: {location.Latitude:0.000}";
        labelLongitude.Text = $"経度: {location.Longitude:0.000}";
        labelAltitude.Text = $"高度: {location.Altitude:0.000}";
    }
}