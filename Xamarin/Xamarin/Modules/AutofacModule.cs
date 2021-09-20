using Autofac;
using Xamarin.Forms;
using XamarinUI.Navigation;
using XamarinUI.Navigation.Interfaces;
using XamarinUI.Factory.Interfaces;
using XamarinUI.Factory;
using XamarinUI.Views;

namespace XamarinUI.Modules
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ViewFactory>().As<IViewFactory>().SingleInstance();

            builder.RegisterType<Navigator>().As<INavigator>().SingleInstance();

            //Lazy<> because the Bootstrapping is done before the page is loaded.
            builder.Register<INavigation>(context => App.Current.MainPage.Navigation).SingleInstance();
        }
    }
}
