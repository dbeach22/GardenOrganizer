using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinUI.Factory.Interfaces;
using XamarinUI.Modules;
using XamarinUI.ViewModels;
using XamarinUI.Views;

namespace XamarinUI.Autofac
{
    public class BootStrapper : AutofacBootStrapper
    {
        private App _app;

        public BootStrapper(App app)
        {
            _app = app;
        }

        /// <summary>
        /// ConfigureContainer
        /// </summary>
        /// <param name="builder">Autofac.ContainerBuilder</param>
        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            base.ConfigureContainer(builder);

            builder.RegisterModule<ViewModule>();
            builder.RegisterModule<ServiceModule>();
        }

        /// <summary>
        /// ConfigureApplication
        /// </summary>
        /// <param name="container">Autofac.IContainer</param>
        protected override void ConfigureApplication(IContainer container)
        {
            IViewFactory viewFactory = container.Resolve<IViewFactory>();
            Page mainPage = viewFactory.Resolve<MainViewModel>();
            NavigationPage navigationPage = new NavigationPage(mainPage);
            _app.MainPage = navigationPage;
        }

        /// <summary>
        /// Registers all of the views with their view models.  This allows for view model navigation.
        /// </summary>
        /// <param name="viewFactory">XamarinUI.Factory.Interfaces.IViewFactory</param>
        protected override void RegisterViews(IViewFactory viewFactory)
        {
            viewFactory.Register<MainViewModel, MainPage>();
            viewFactory.Register<SeedListViewModel, SeedListPage>();
            viewFactory.Register<SeedTypeViewModel, SeedTypePage>();
            viewFactory.Register<AddNewSeedTypeViewModel, AddNewSeedTypePage>();
        }
    }
}
