using Autofac;
using System;
using System.Collections.Generic;

namespace XamarinUI.Modules
{
    public class MappedTypeModule : Module
    {
        private Dictionary<Type, Type> _mappedTypes;

        /// <summary>
        /// MappedTypeModule
        /// </summary>
        /// <param name="mappedTypes">System.Collections.Generic.Dictionary</param>
        public MappedTypeModule(Dictionary<Type, Type> mappedTypes)
        {
            _mappedTypes = mappedTypes;
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="builder">Autofac ContainerBuilder</param>
        protected override void Load(ContainerBuilder builder)
        {
            foreach (var kvp in _mappedTypes)
            {
                builder.RegisterType(kvp.Value).As(kvp.Key);
            }
        }
    }
}
