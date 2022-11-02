using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.ComponentModel.DataAnnotations;
using WpfSample.Views;

namespace WpfSample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private IRegionManager _regionManager;
        private IDialogService _dialogService;
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _systemDate = System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
        public string SystemDate
        {
            get { return _systemDate; }
            set { SetProperty(ref _systemDate, value); }
        }

        public DelegateCommand UpdateSystemDateCommand { get; }
        public DelegateCommand ShowViewACommand { get; }
        public DelegateCommand ShowViewAWithParamCommand { get; }
        public DelegateCommand ShowViewBCommand { get; }


        public MainWindowViewModel(IRegionManager regionManager,IDialogService dialogService)
        {
            _regionManager = regionManager;
            _dialogService = dialogService;
            UpdateSystemDateCommand = new DelegateCommand(UpdateSystemDateExecute);
            ShowViewACommand = new DelegateCommand(ShowViewAExecute);
            ShowViewAWithParamCommand = new DelegateCommand(ShowViewAWithParamExecute);
            ShowViewBCommand = new DelegateCommand(ShowViewBExecute);
        }

        private void UpdateSystemDateExecute()
        {
            SystemDate = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
        }

        private void ShowViewAExecute()
        {
            _regionManager.RequestNavigate("ContentRegion",     // 表示させたい場所
                                            nameof(ViewA));
        }

        private void ShowViewBExecute()
        {
            var p = new DialogParameters();
            p.Add(nameof(ViewBViewModel.ViewBTextBox), SystemDate);
            _dialogService.ShowDialog(nameof(ViewB), p, ViewBClose /*画面が閉じられた時に実行される関数*/);
        }

        private void ViewBClose(IDialogResult result)
        {
            if(result.Result == ButtonResult.OK)
            {
                SystemDate = result.Parameters.GetValue<string>(nameof(ViewBViewModel.ViewBTextBox));
            }
        }

        private void ShowViewAWithParamExecute()
        {
            var p = new NavigationParameters();
            p.Add(nameof(ViewAViewModel.MyLabel), SystemDate);
            _regionManager.RequestNavigate("ContentRegion",     // 表示させたい場所
                                            nameof(ViewA),
                                            p);                 // パラメータ
        }
    }
}
