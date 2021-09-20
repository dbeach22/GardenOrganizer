using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using XamarinUI.ViewModels.Interfaces;
using XamarinUI.Navigation.Interfaces;
using XamarinUI.Messages.Interfaces;

namespace XamarinUI.ViewModels
{
    public abstract class BaseViewModel : IViewModel
    {
        private readonly INavigator _navigator;
        private readonly IToastMessage _toastMessage;

        /// <summary>
        /// Base Constructor
        /// </summary>
        /// <param name="navigator">XamarinUI.Navigation.InterfacesINavigator</param>
        /// <param name="toastMessage">XamarinUI.Messages.Interfaces.IToastMessage</param>
        public BaseViewModel(INavigator navigator, IToastMessage toastMessage)
        {
            _navigator = navigator;
            _toastMessage = toastMessage;
            Parameters = new Dictionary<string, string>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Returns the INavigator instance
        /// </summary>
        /// <returns>XamarinUI.Navigation.InterfacesINavigator</returns>
        public INavigator GetNavigator()
        {
            return _navigator;
        }

        /// <summary>
        /// Returns the platform specific ToastMessage
        /// </summary>
        /// <returns>XamarinUI.Messages.Interfaces.IToastMessage</returns>
        public IToastMessage GetToastMessage()
        {
            return _toastMessage;
        }

        /// <summary>
        /// Stores any parameters passed from one view model to another during navigation
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Property changes
        /// </summary>
        /// <param name="propertyName">Name of the property changed</param>
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Allows a view model to populate a page OnAppearing.
        /// </summary>
        public virtual void OnAppearing()
        {

        }
    }
}
