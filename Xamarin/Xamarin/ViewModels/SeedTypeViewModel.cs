using BAL.Models;
using BAL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinUI.Factory.Interfaces;
using XamarinUI.Messages.Interfaces;
using XamarinUI.Navigation.Interfaces;

namespace XamarinUI.ViewModels
{
    public class SeedTypeViewModel : BaseViewModel
    {
        private readonly ISeedTypeService _seedTypeService;
        private readonly IViewFactory _viewFactory;
        private SeedType _selectedItem;

        /// <summary>
        /// SeedTypeViewModel constructor
        /// </summary>
        /// <param name="navigator">XamarinUI.Navigation.Interfaces.INavigator</param>
        /// <param name="toastMessage">XamarinUI.Messages.Interfaces.IToastMessage</param>
        /// <param name="seedTypeService">BAL.Services.Interfaces.ISeedTypeService</param>
        /// <param name="viewFactory">XamarinUI.Factory.Interfaces.IViewFactory</param>
        public SeedTypeViewModel(INavigator navigator, IToastMessage toastMessage, ISeedTypeService seedTypeService, IViewFactory viewFactory)
            : base(navigator, toastMessage)
        {
            _seedTypeService = seedTypeService;
            _viewFactory = viewFactory;
            SeedListCommand = new Command(NavigateSeedListPage);
            AddNewSeedTypeCommand = new Command(NavigateAddNewSeedTypePage);
            OCSeedTypes = new ObservableCollection<SeedType>();

            LoadSeedTypes();
        }

        /// <summary>
        /// Command to navigate to the Add New Seed Type view
        /// </summary>
        public ICommand AddNewSeedTypeCommand { get; set; }

        /// <summary>
        /// Command to navigate to the Seed List view
        /// </summary>
        public ICommand SeedListCommand { get; set; }

        public ObservableCollection<SeedType> OCSeedTypes { get; set; }

        /// <summary>
        /// The SeedTypeListView SelectedItem is bound to this property.
        /// When the user selects a seed type from the list the SelectedItem's information
        /// Is passed to the SeedListPage to display only seeds for that type
        /// </summary>
        public SeedType SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;

                if (_selectedItem != null)
                {
                    SeedListCommand.Execute(_selectedItem);
                }

                _selectedItem = null;
            }
        }

        /// <summary>
        /// Uses the SeedTypeService to load the SeedTypes.
        /// For testing purposes the SeedTypeTestService is used with preloaded seed types.
        /// The SeedTypeDBService will be used to connect to a local Sqlite Database.
        /// The SeedTypeApiService will be used to connect to an api to pull the seed types.
        /// </summary>
        private async void LoadSeedTypes()
        {
            IList<SeedType> temp = await _seedTypeService.GetList();

            OCSeedTypes.Clear();

            foreach (SeedType s in temp)
            {
                OCSeedTypes.Add(s);
            }
        }

        public override void OnAppearing()
        {
            
        }

        private async void NavigateSeedListPage()
        {
            try
            {
                Dictionary<string, string> _parameters = new Dictionary<string, string>();
                _parameters.Add("Id", _selectedItem.Id.ToString());
                _parameters.Add("Type", _selectedItem.Type);

                Page seedListPage = _viewFactory.Resolve<SeedListViewModel>(_parameters);
                await GetNavigator().PushAsync(seedListPage);
            }
            catch (Exception ex)
            {
                GetToastMessage().Show(ex.Message);
            }
        }

        private async void NavigateAddNewSeedTypePage()
        {
            try
            {
                await GetNavigator().PushAsync<AddNewSeedTypeViewModel>();

            }
            catch (Exception ex)
            {
                GetToastMessage().Show(ex.Message);
            }
        }
    }
}
