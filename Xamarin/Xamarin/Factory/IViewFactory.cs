using System.Collections.Generic;
using Xamarin.Forms;
using XamarinUI.ViewModels.Interfaces;

namespace XamarinUI.Factory.Interfaces
{
    public interface IViewFactory
    {
        void Register<TViewModel, TView>() where TViewModel : class, IViewModel where TView : Page;

        Page Resolve<TViewModel>() where TViewModel : class, IViewModel;

        Page Resolve<TViewModel>(Dictionary<string, string> parameter) where TViewModel : class, IViewModel;
    }
}
