namespace MauiTestApp;

public partial class DialogPage : ContentPage
{
	public DialogPage()
	{
		InitializeComponent();
	}

	private async void DisplayAlertClicked(object sender, EventArgs e)
	{
		await DisplayAlert("�^�C�g��", "���b�Z�[�W", "�I�b�P�[", "�L�����Z��");
	}
}