using Autofac;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinUI.Factory.Interfaces;
using XamarinUI.ViewModels.Interfaces;

namespace XamarinUI.Factory
{
    public class ViewFactory : IViewFactory
    {
        private readonly IDictionary<Type, Type> _map = new Dictionary<Type, Type>();
        private readonly IComponentContext _componentContext;

        /// <summary>
        /// View Factory Constructor
        /// </summary>
        /// <param name="componentContext">Autofac.IComponentContext</param>
        public ViewFactory(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        /// <summary>
        /// Maps the views to the view models
        /// </summary>
        /// <typeparam name="TViewModel">XamarinUI.ViewModels.Interfaces.IViewModel</typeparam>
        /// <typeparam name="TView">Xamarin.Forms.Page</typeparam>
        public void Register<TViewModel, TView>() where TViewModel : class, IViewModel where TView : Page
        {
            _map[(typeof(TViewModel))] = typeof(TView);
        }

        /// <summary>
        /// Resolves the Page from the view model
        /// </summary>
        /// <typeparam name="TViewModel">XamarinUI.ViewModels.Interfaces.IViewModel</typeparam>
        /// <returns>Xamarin.Forms.Page</returns>
        public Page Resolve<TViewModel>() where TViewModel : class, IViewModel
        {
            TViewModel viewModel = _componentContext.Resolve<TViewModel>();
            Type viewType = _map[(typeof(TViewModel))];

            Page view = _componentContext.Resolve(viewType) as Page;

            view.BindingContext = viewModel;
            return view;
        }

        /// <summary>
        /// Resolves the Page from the view model.  Allows for view models to pass parameters to other view models.
        /// </summary>
        /// <typeparam name="TViewModel">XamarinUI.ViewModels.Interfaces.IViewModel</typeparam>
        /// <param name="parameters">System.Collections.Generic.Dictionary</param>
        /// <returns>Xamarin.Forms.Page</returns>
        public Page Resolve<TViewModel>(Dictionary<string, string> parameters) where TViewModel : class, IViewModel
        {
            TViewModel viewModel = _componentContext.Resolve<TViewModel>();
            Type viewType = _map[(typeof(TViewModel))];

            Page view = _componentContext.Resolve(viewType) as Page;

            view.BindingContext = viewModel;

            viewModel.Parameters = parameters;

            return view;
        }
    }
}
