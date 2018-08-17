using Prism.Navigation;
using Xamarin.Forms;

namespace PoketDex.Views
{
    public partial class BaseNavigationPage : NavigationPage, INavigationPageOptions
    {
        public bool ClearNavigationStackOnNavigation
        {
            get { return true; }
        }
        public BaseNavigationPage()
        {
            InitializeComponent();
        }
    }
}
