using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDialog.ViewModels
{
    public class MsgViewModel : BindableBase,IDialogAware
    {
        public string Title{ set; get; }

        public event Action<IDialogResult> RequestClose;

        public DelegateCommand OkCommand { get; set; }
        public DelegateCommand CancleCommand { get; set; }

        public MsgViewModel()
        {
            OkCommand = new DelegateCommand(() =>
            {
                //成功时构造返回结果返回出去(也是键值对)
                DialogParameters param = new DialogParameters();
                param.Add("Value", Title);
                RequestClose?.Invoke(new DialogResult(ButtonResult.OK, param));
            });
            CancleCommand = new DelegateCommand(() =>
            {
                RequestClose?.Invoke(new DialogResult(ButtonResult.No));
            });
        }

        //是否允许关闭当前窗口
        public bool CanCloseDialog()
        {
            return true;    
        }

        //关闭时触发
        public void OnDialogClosed()
        {
            
        }

        //打开前触发(用于接受参数)
        public void OnDialogOpened(IDialogParameters parameters)
        {
            Title = parameters.GetValue<string>("Value");
        }
    }
}
