namespace MauiTestApp
{
    public class TextPageViewModel  : BindableBase
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

        private DelegateCommand _enterCommand;

        public DelegateCommand EnterCommand
        {
            get
            {
                return _enterCommand ?? (_enterCommand = new DelegateCommand(() => { Result = $"{Name} {Age} {Address}"; }));
            }
        }
    }

}
