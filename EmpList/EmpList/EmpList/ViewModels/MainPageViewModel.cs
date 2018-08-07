using Prism.Navigation;

namespace EmpList.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
        }
    }
}
