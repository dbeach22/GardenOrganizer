using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinUI.ViewModels.Interfaces;

namespace XamarinUI.Navigation.Interfaces
{
    public interface INavigator
    {
        Task PopAsync();

        Task PopToRootAsync();

        Task PushAsync<TViewModel>() where TViewModel : class, IViewModel;

        Task PushAsync(Page page);

        Task PushModalAsync<TViewModel>() where TViewModel : class, IViewModel;

        Task PushModalAsync(Page page);
    }
}
