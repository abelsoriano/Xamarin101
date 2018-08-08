using EmpList.Models;
using Prism.Navigation;

namespace EmpList.ViewModels
{
	public class BeerDetailsPageViewModel : ViewModelBase
    {
        private Beer _beer;

        public Beer Beer
        {
            get => _beer;
            set => SetProperty(ref _beer, value);
        }

        public BeerDetailsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _beer = new Beer();
        }
      //  private Beer _beer;
        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            Beer= (Beer)parameters["model"];
         }
    }
}
