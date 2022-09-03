using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace MauiTestApp;

public partial class WebApiLambda : ContentPage
{
	public WebApiLambda()
	{
		InitializeComponent();
	}

    private async void OnClicked(object sender, EventArgs e)
    {
        var url = $"https://rb5lyc8l67.execute-api.us-east-1.amazonaws.com/dev/sample";
        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(url);
        label1.Text = await response.Content.ReadAsStringAsync();

        //var jsonSerializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        //cv.ItemsSource = books;
    }
}

public class Person
{
    [Key]
    public string Text { get; set; }
}