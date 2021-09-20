using Autofac;
using XamarinUI.Factory;
using XamarinUI.Factory.Interfaces;
using XamarinUI.ViewModels;
using XamarinUI.Views;

namespace XamarinUI.Modules
{
    public class ViewModule : Module
    {
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="builder">Autofac ContainerBuilder</param>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ViewFactory>().As<IViewFactory>().SingleInstance();

            builder.RegisterType<MainPage>().SingleInstance();
            builder.RegisterType<MainViewModel>().SingleInstance();

            builder.RegisterType<SeedListPage>().SingleInstance();
            builder.RegisterType<SeedListViewModel>().SingleInstance();

            builder.RegisterType<SeedTypePage>().SingleInstance();
            builder.RegisterType<SeedTypeViewModel>().SingleInstance();

            builder.RegisterType<AddNewSeedTypePage>().SingleInstance();
            builder.RegisterType<AddNewSeedTypeViewModel>().SingleInstance();
        }
    }
}
