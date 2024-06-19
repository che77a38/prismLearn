using Prism.Ioc;
using System.Windows;
using testNavigation.Views;

namespace testNavigation
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
            //此处要注册各种资源
            //默认名为ViewA
            //containerRegistry.RegisterForNavigation<ViewA>();
            //起名方式
            containerRegistry.RegisterForNavigation<ViewA>("PageA");
            containerRegistry.RegisterForNavigation<ViewB>();
        }
    }
}
