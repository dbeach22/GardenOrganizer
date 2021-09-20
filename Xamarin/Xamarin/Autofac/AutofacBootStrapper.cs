using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using XamarinUI.Factory.Interfaces;
using XamarinUI.Modules;

namespace XamarinUI.Autofac
{
    public abstract class AutofacBootStrapper
    {
        private Dictionary<Type, Type> _mappedTypes;

        /// <summary>
        /// Gets a dictionary of platform specific dependencies
        /// </summary>
        /// <param name="mappedTypes">Dictionary of platform specific dependencies</param>
        public void Run(Dictionary<Type, Type> mappedTypes)
        {
            _mappedTypes = mappedTypes;

            ContainerBuilder builder = new ContainerBuilder();

            ConfigureContainer(builder);

            IContainer container = builder.Build();

            IViewFactory viewFactory = container.Resolve<IViewFactory>();

            RegisterViews(viewFactory);

            ConfigureApplication(container);
        }

        /// <summary>
        /// ConfigureContainer
        /// </summary>
        /// <param name="builder">Autofac.ContainerBuilder</param>
        protected virtual void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<AutofacModule>();

            if (_mappedTypes != null && _mappedTypes.Any())
            {
                builder.RegisterModule(new MappedTypeModule(_mappedTypes));
            }
        }

        /// <summary>
        /// RegisterViews
        /// </summary>
        /// <param name="viewFactory">XamarinUI.Factory.Interfaces.IViewFactory</param>
        protected abstract void RegisterViews(IViewFactory viewFactory);

        /// <summary>
        /// ConfigureApplication
        /// </summary>
        /// <param name="container">Autofac.IContainer</param>
        protected abstract void ConfigureApplication(IContainer container);
    }
}
