using Microsoft.Maui.Controls;
using System.Diagnostics.Metrics;

namespace MauiTestApp;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
		Loaded += LoadDataList;
	}

    private void LoadDataList(object sender, EventArgs eventArgs)
    {
        var personList = new List<Person>()
        {
            new Person{ Name="A‚³‚ñ", Id=1000},
            new Person{ Name="B‚³‚ñ", Id=2000},
        };
        cv.ItemsSource = personList;
    }

    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
        var item = cv.SelectedItem as Person;
        DisplayAlert("Choice!", $"Name={item.Name} Id={item.Id}", "OK");
	}

    private class Person
    {
        public string Name { get; init; }
        public int Id { get; init; }
    }
}