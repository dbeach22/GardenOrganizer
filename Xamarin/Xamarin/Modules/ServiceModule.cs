using Autofac;
using BAL.Services;
using BAL.Services.Interfaces;

namespace XamarinUI.Modules
{
    public class ServiceModule : Module
    {
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="builder">Autofac ContainerBuilder</param>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DAL.Services.DatabaseService>().As<FatHead.Services.Interfaces.IDatabaseService>().SingleInstance();
            builder.RegisterType<FatHead.Converters.DataConverter>().As<FatHead.Converters.Interfaces.IDataConverter>().SingleInstance();
            builder.RegisterType<FatHead.Loggers.Logger>().As<FatHead.Loggers.Interfaces.ILogger>();

            builder.RegisterType<SeedTestService>().As<ISeedService>().SingleInstance();
            builder.RegisterType<SeedTypeTestService>().As<ISeedTypeService>().SingleInstance();
        }
    }
}
