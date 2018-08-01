using Prism.Navigation;

namespace PrismSeries.ViewModels
{
	public class SeriesListPageViewModel : ViewModelBase
    {
        public SeriesListPageViewModel(INavigationService navigationService)
            :base (navigationService)
        {
            Title = "Prism Series";
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }
}
