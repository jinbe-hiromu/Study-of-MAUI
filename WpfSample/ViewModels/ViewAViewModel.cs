using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WpfSample.ViewModels
{
    public class ViewAViewModel : BindableBase, INavigationAware
    {
        private string _myLabel = string.Empty;

        public string MyLabel
        {
            get { return _myLabel; }
            set { SetProperty(ref _myLabel, value); }
        }

        public ViewAViewModel()
        {

        }

        // 画面遷移で通過
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            MyLabel = navigationContext.Parameters.GetValue<string>(nameof(MyLabel));
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;       // true: インスタンスを使いまわす．　false: 毎回インスタンスを生成する
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            // 画面から離れる時に実行
        }
    }
}
