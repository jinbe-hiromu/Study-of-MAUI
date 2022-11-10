using System.Windows.Input;

namespace MauiTestApp
{
    public class DelegateCommand : ICommand
    {
        private Action _action;

        public DelegateCommand(Action action)
        {//コンストラクタでActionを登録
            _action = action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {//とりあえずActionがあれば実行可能
            return _action != null;
        }

        public void Execute(object parameter)
        {//今回は引数を使わずActionを実行
            _action?.Invoke();
        }
    }
}
