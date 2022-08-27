namespace MauiTestApp;

public partial class DialogPage : ContentPage
{
	public DialogPage()
	{
		InitializeComponent();
	}

	private async void DisplayAlertClicked(object sender, EventArgs e)
	{
		await DisplayAlert("タイトル", "メッセージ", "オッケー", "キャンセル");
	}
}