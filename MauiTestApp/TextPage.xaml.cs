namespace MauiTestApp;

public partial class TextPage : ContentPage
{
	public TextPage()
	{
		InitializeComponent();
	}

	private MainViewModel _vm;

	protected override void OnAppearing()
	{
		base.OnAppearing();
		_vm = new MainViewModel();
		BindingContext = _vm;
	}

	public void OnInputClicked(object sender, EventArgs e)
	{
		_vm.Result = $"{_vm.Name} {_vm.Age} {_vm.Address}";
	}
}

// ReactiveProperty を NuGet から追加
internal class MainViewModel : Prism.Mvvm.BindableBase
{
	public string Name { get; set; } = string.Empty;
	public int Age { get; set; } = 0;
    public string Address { get; set; } = string.Empty;

	public string _result = string.Empty;
	public string Result
	{
		get => _result;
		set => SetProperty(ref _result, value, nameof(Result));
	}
}