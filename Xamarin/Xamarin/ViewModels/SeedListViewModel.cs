using BAL.Models;
using BAL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinUI.Messages.Interfaces;
using XamarinUI.Navigation.Interfaces;

namespace XamarinUI.ViewModels
{
    public class SeedListViewModel : BaseViewModel
    {
        private ISeedService _seedService;

        /// <summary>
        /// SeedListViewModel constructor
        /// </summary>
        /// <param name="navigator">XamarinUI.Navigation.Interfaces.INavigator</param>
        /// <param name="toastMessage">XamarinUI.Messages.Interfaces.IToastMessage</param>
        /// <param name="seedService">XamarinUI.Factory.Interfaces.ISeedService</param>
        public SeedListViewModel(INavigator navigator, IToastMessage toastMessage, ISeedService seedService)
            : base(navigator, toastMessage)
        {
            _seedService = seedService;
            OCSeedList = new ObservableCollection<Seed>();

            LoadSeeds();
        }

        public ObservableCollection<Seed> OCSeedList { get; set; }

        /// <summary>
        /// Uses the SeedService to load the seeds for a specific seed type.
        /// For testing purposes the SeedTestService is used with preloaded seeds.
        /// The SeedDBService will be used to connect to a local Sqlite Database.
        /// The SeedApiService will be used to connect to an api to pull the seed types.
        /// </summary>
        private async void LoadSeeds()
        {
            IList<Seed> temp = await _seedService.GetList(GetSeedTypeParameter());

            OCSeedList.Clear();

            foreach (Seed s in temp)
            {
                OCSeedList.Add(s);
            }
        }

        private string GetSeedTypeParameter()
        {
            foreach (var p in Parameters)
            {
                if (p.Key == "Type")
                {
                    return p.Value;
                }
            }

            return string.Empty;
        }

        public override void OnAppearing()
        {
            
        }
    }
}
