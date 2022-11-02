using Prism.Ioc;
using System.Windows;
using WpfSample.ViewModels;
using WpfSample.Views;

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();       // Navigationを使用するには，事前に登録させる必要がある．
            containerRegistry.RegisterDialog<ViewB, ViewBViewModel>();
        }
    }
}
