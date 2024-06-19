using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace testNavigation.ViewModels
{
    //继承BindableBase用于实现通知,继承INavigationAware用于实现view导航,可以使用IConfirmNavigationRequest代替INavigationAware,就可以多一个ConfirmNavigationRequest方法用于判断是否允许导航(IConfirmNavigationRequest是继承INavigationAware)
    public class ViewAViewModel : BindableBase,IConfirmNavigationRequest
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        //判断是否允许导航
        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            bool result = true;
            if(MessageBox.Show("确认导航","温馨提示",MessageBoxButton.YesNo)==MessageBoxResult.No)
                result = false;
            //固定格式
            continuationCallback(result);
        }

        /// <summary>
        /// 重新创建实例的一个判断,如果已经打开过当前实例的话,如果打开过还返回一个true的话,他会创建一个新的实例覆盖原来的
        /// </summary>
        /// <param name="navigationContext"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        /// <summary>
        /// 导航离开当前页时触发
        /// </summary>
        /// <param name="navigationContext"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        /// <summary>
        /// 导航完成前,接收用户传递的参数以及是否允许导航等控制
        /// </summary>
        /// <param name="navigationContext"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            //接收Value键对应的值(string类型)
            title = navigationContext.Parameters.GetValue<string>("Value");
        }
    }
}
