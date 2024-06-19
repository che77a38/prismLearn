using Prism.Ioc;
using System.Windows;
using testDialog.ViewModels;
using testDialog.Views;

namespace testDialog
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
            //注册对话组件
            containerRegistry.RegisterDialog<MsgView, MsgViewModel>("dialogView");
        }
    }
}
