using Prism.Navigation;

namespace PoketDex.ViewModels
{
    public class MainPageViewModel : ViewModelBase
	{
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Pokedex";
        }
	}
}
