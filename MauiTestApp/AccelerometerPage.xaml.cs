namespace MauiTestApp;

public partial class AccelerometerPage : ContentPage
{
	public AccelerometerPage()
	{
		InitializeComponent();
	}

    private void OnClicked(object sender, EventArgs e)
    {
        Accelerometer.ReadingChanged += ReadingChanged;
        Accelerometer.Start(new SensorSpeed());
    }

    private void ReadingChanged(object sender, AccelerometerChangedEventArgs e)
    {
        var x = e.Reading.Acceleration.X;
        var y = e.Reading.Acceleration.Y;
        var z = e.Reading.Acceleration.Z;

        labelX.Text = $"X: {x:0.000}";
        labelY.Text = $"Y: {y:0.000}";
        labelZ.Text = $"Z: {z:0.000}";
    }
}