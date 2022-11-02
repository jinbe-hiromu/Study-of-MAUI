using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using WpfSample.Views;

namespace WpfSample.ViewModels
{
    public class ViewBViewModel : BindableBase, IDialogAware
    {
        private string _viewBTextBox = "XXX";

        public string ViewBTextBox
        {
            get { return _viewBTextBox; }
            set { SetProperty(ref _viewBTextBox, value); }
        }

        public DelegateCommand OkCommand { get; }


        public ViewBViewModel()
        {
            OkCommand = new DelegateCommand(OkCommandExecute);
        }

        public string Title => "Title VeiwB";

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;        // true:画面が閉じる，false:画面閉じれない
        }

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            ViewBTextBox = parameters.GetValue<string>(nameof(ViewBTextBox));
        }

        private void OkCommandExecute()
        {
            var p = new DialogParameters();
            p.Add(nameof(ViewBTextBox), ViewBTextBox);
            RequestClose?.Invoke(new DialogResult(ButtonResult.OK, p));
        }
    }
}
