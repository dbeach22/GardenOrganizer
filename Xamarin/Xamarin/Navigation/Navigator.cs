using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinUI.Navigation.Interfaces;
using XamarinUI.Factory.Interfaces;
using XamarinUI.ViewModels.Interfaces;

namespace XamarinUI.Navigation
{
    public class Navigator : INavigator
    {
        private readonly Lazy<INavigation> _navigation;
        private readonly IViewFactory _viewFactory;

        /// <summary>
        /// Navigator Constructor
        /// </summary>
        /// <param name="navigation">Xamarin.Forms.INavigation</param>
        /// <param name="viewFactory">Xamarin.ViewFactory.Interfaces.IViewFactory</param>
        public Navigator(Lazy<INavigation> navigation, IViewFactory viewFactory)
        {
            _navigation = navigation;
            _viewFactory = viewFactory;
        }

        /// <summary>
        /// Xamarin.Forms.INavigation
        /// </summary>
        private INavigation Navigation
        {
            get
            {
                return _navigation.Value;
            }
        }

        public async Task PopAsync()
        {
            await Navigation.PopAsync();
        }

        public async Task PopToRootAsync()
        {
            await Navigation.PopToRootAsync();
        }

        /// <summary>
        /// PushAsync with IViewModel
        /// </summary>
        /// <typeparam name="TViewModel">Xamarin.ViewModels.Interfaces.IViewModel</typeparam>
        /// <returns>Task</returns>
        public async Task PushAsync<TViewModel>() where TViewModel : class, IViewModel
        {
            await Navigation.PushAsync(_viewFactory.Resolve<TViewModel>());
        }

        /// <summary>
        /// PushAsync with Page that has parameters.  The page is Resolved with parameters and passed here.
        /// </summary>
        /// <param name="page">Xamarin.Forms.Page</param>
        /// <returns>Task</returns>
        public async Task PushAsync(Page page)
        {
            await Navigation.PushAsync(page);
        }

        /// <summary>
        /// PushModalAsync with IViewModel
        /// </summary>
        /// <typeparam name="TViewModel">Xamarin.ViewModels.Interfaces.IViewModel</typeparam>
        /// <returns>Task</returns>
        public async Task PushModalAsync<TViewModel>() where TViewModel : class, IViewModel
        {
            await Navigation.PushModalAsync(_viewFactory.Resolve<TViewModel>());
        }

        /// <summary>
        /// PushModalAsync with Page that has parameters.  The page is Resolved with parameters and passed here.
        /// </summary>
        /// <param name="page">Xamarin.Forms.Page</param>
        /// <returns>Task</returns>
        public async Task PushModalAsync(Page page)
        {
            await Navigation.PushModalAsync(page);
        }
    }
}
