using Prism.Commands;
using System.Collections.ObjectModel;
using EmpList.Interfaces;
using EmpList.Models;
using Prism.Navigation;

namespace EmpList.ViewModels
{
	public class BeersListPageViewModel : ViewModelBase
    {
        private readonly IApiService _apiService;
        private readonly INavigationService _navigationService;

        private ObservableCollection<Beer> _beers;

        public ObservableCollection<Beer> Beers
        {
            get => _beers;
            set => SetProperty(ref _beers, value);
        }

        public BeersListPageViewModel(INavigationService navigationService, IApiService apiService) : base(navigationService)
        {
            _apiService = apiService;
            _navigationService = navigationService;

            Title = "Beers List";
            Beers = new ObservableCollection<Beer>();

            GetBeersFromApi();

            NavigateCommand = new DelegateCommand(Navigate);
               
        }

        async void Navigate()
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("model", _selectedBeer);
            await _navigationService.NavigateAsync("BeerDetailsPage", navigationParams);
        }

        private Beer _selectedBeer;
        public Beer SelectedBeer
        {
            get => _selectedBeer;
            set => SetProperty(ref _selectedBeer, value);
        }

        public DelegateCommand NavigateCommand { get; private set; }

        async void GetBeersFromApi()
        {
            IsRunning = true;
            var result = await _apiService.GetAllBeerss();
            IsRunning = false;

            foreach (var item in result)
            {
                Beers.Add(item);
            }
        }
    }
}
