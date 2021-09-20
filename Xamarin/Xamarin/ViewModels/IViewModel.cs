using System.Collections.Generic;
using System.ComponentModel;

namespace XamarinUI.ViewModels.Interfaces
{
    public interface IViewModel : INotifyPropertyChanged
    {
        Dictionary<string, string> Parameters { get; set; }

        void OnAppearing();
    }
}
