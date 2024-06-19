using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Runtime.CompilerServices;

namespace testNavigation.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly IRegionManager regionManager;
        //用于记录日志情况
        IRegionNavigationJournal journal;

        public DelegateCommand OpenACommand { get; set; }
        public DelegateCommand OpenBCommand { get; set; }
        public DelegateCommand GoBackCommand { get; set; }
        public DelegateCommand GoForwordCommand { get; set; }



        public MainWindowViewModel(IRegionManager regionManager)
        {
            OpenACommand = new DelegateCommand(OpenA);
            OpenBCommand = new DelegateCommand(OpenB);
            GoBackCommand = new DelegateCommand(GoBack);
            GoForwordCommand = new DelegateCommand(GoForword);
            this.regionManager = regionManager;
        }

        private void OpenA()
        {

            //传递参数给ViewA
            NavigationParameters param = new NavigationParameters();
            //参数传递的方式是通过键值对
            param.Add("Value", "Hello");
            //导航到ViewA(带参数)
            //regionManager.RequestNavigate("ContentRegion", nameof(Views.ViewA),param);
            //使用字符串导航(带参数)
            //regionManager.RequestNavigate("ContentRegion", "PageA",param);
            //传递参数的另一种写法(类似html的写法)   顺便加上了获取上下文日志
            regionManager.RequestNavigate("ContentRegion", $"PageA?Value=Hello1", arg =>
            {
                //导航后拿到上下文日志
                journal = arg.Context.NavigationService.Journal;
            });
        }

        private void OpenB()
        {
            //导航到ViewB(第三个参数设置导航完成的时候触发回调函数)
            regionManager.RequestNavigate("ContentRegion", nameof(Views.ViewB), arg =>
            {
                //导航后拿到上下文日志
                journal = arg.Context.NavigationService.Journal;
            });
        }

        private void GoBack()
        {
            journal.GoBack();
        }

        private void GoForword()
        {
            journal.GoForward();
        }

    }
}
