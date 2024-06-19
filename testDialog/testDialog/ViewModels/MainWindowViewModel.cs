using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System.Windows;
using testDialog.Views;

namespace testDialog.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand ShowDialogCommand {  get; private set; }

        //对话框服务
        private readonly IDialogService dialog;

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        //增加IDialogService参数
        public MainWindowViewModel(IDialogService dialog)
        {
            ShowDialogCommand = new DelegateCommand(ShowDialog);
            this.dialog = dialog;
        }

        private void ShowDialog()
        {
            //添加参数
            DialogParameters param = new DialogParameters();
            param.Add("Value", "Hello");
            //显示对话框(不带参数)
            //dialog.ShowDialog("dialogView");
            //显示对话框阳
            dialog.ShowDialog("dialogView",param, arg =>
            {
                if(arg.Result == ButtonResult.OK)
                {
                    //获取返回的结果
                    MessageBox.Show(arg.Parameters.GetValue<string>("Value"));
                }
            });
        }
    }
}
