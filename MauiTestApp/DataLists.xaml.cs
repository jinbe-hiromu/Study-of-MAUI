namespace MauiTestApp;

public partial class DataLists : ContentPage
{
    public DataLists()
    {
        InitializeComponent();
    }

    private void MainPage_LayoutChanged(object sender, EventArgs eventArgs)
    {
        var cardList = new List<Card>()
        {
            new Card { ImageUrl = "cook.jpg", Name = "Cokking", Location = "Japan" },
            new Card { ImageUrl = "book.jpg", Name = "Book", Location = "Korea" },
            new Card { ImageUrl = "dotnet_bot.svg", Name = "MAUI", Location = "USA" }
        };
        _collectionView.ItemsSource = cardList;
    }

    private void OnGoBackClicked(object sender, EventArgs eventArgs)
    {
        Navigation.PopAsync();
    }
}
