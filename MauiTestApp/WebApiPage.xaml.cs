using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace MauiTestApp;

public partial class WebApiPage : ContentPage
{
	public WebApiPage()
	{
		InitializeComponent();
	}

	private async void OnClicked(object sender, EventArgs e)
	{
		var url = $"https://moonmile-gyakubiki.azurewebsites.net/api/books";
        var httpClient = new HttpClient();
		var response = await httpClient.GetAsync(url);
        var jsonSerializerOptions = new JsonSerializerOptions(){ PropertyNameCaseInsensitive = true};
		var books = await JsonSerializer.DeserializeAsync<List<Book>>(response.Content.ReadAsStream(), jsonSerializerOptions);
		cv.ItemsSource = books;
	}
}

public class Book
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public int? AuthorId { get; set; }
    public int? PublisherId { get; set; }
    public int Price { get; set; }
    // 関連するテーブル
    public Author Author { get; set; }
    public Publisher Publisher { get; set; }
}

public class Author
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = "";
}

public class Publisher
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Telephone { get; set; } = "";
    public string Address { get; set; } = "";
}