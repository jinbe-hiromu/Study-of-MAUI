using System.Diagnostics;

namespace MauiTestApp;

public partial class DataLists : ContentPage
{
    private int _counter = 0;

    public DataLists()
    {
        InitializeComponent();
        LayoutChanged += DataList_LayoutChanged;
    }

    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();

    //}

    private void DataList_LayoutChanged(object sender, EventArgs eventArgs)
    {
        var cardList = new List<Card>()
        {
            new Card { ImageUrl = "cook.jpg", Name = "Cokking", Location = "Japan" },
            new Card { ImageUrl = "book.jpg", Name = "Book", Location = "Korea" },
            new Card { ImageUrl = "cook.png", Name = "Cokking2", Location = "Japan" },
            new Card { ImageUrl = "book.png", Name = "Book2", Location = "Korea" },
            new Card { ImageUrl = "dotnet_bot.svg", Name = "MAUI", Location = "USA" }
        };
        _collectionView.ItemsSource = cardList;

        _counter++;
        Debug.WriteLine(_counter);
    }

    private void OnGoBackClicked(object sender, EventArgs eventArgs)
    {
        Navigation.PopAsync();
    }
}
