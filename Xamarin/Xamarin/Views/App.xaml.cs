using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinUI.Autofac;

namespace XamarinUI.Views
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        public App(string databaseLocation)
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        /// <summary>
        /// Gets a dictionary of platform specific dependencies
        /// </summary>
        /// <param name="mappedTypes">Dictionary of platform specific dependencies</param>
        public void LoadTypes(Dictionary<Type, Type> mappedTypes)
        {
            BootStrapper bootStrapper = new BootStrapper(this);

            bootStrapper.Run(mappedTypes);
        }
    }
}
