using Prism;
using Prism.Ioc;
using mPoketDex.ViewModels;
using mPoketDex.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace mPoketDex
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

          //  await NavigationService.NavigateAsync("NavigationPage/MainPage");
           // await NavigationService.NavigateAsync("BaseNavigationPage/MasterPage");
            if (Device.Idiom == TargetIdiom.Desktop
                || Device.Idiom == TargetIdiom.Tablet)
            {
                await NavigationService.NavigateAsync("MasterDetailPageView/BaseNavigationPage/DetailPage");
            }
            else
            {
                //assume it's phone and navigate clean
               // await NavigationService.NavigateAsync("MasterDetailPageView/BaseNavigationPage/DetailPage");

                await NavigationService.NavigateAsync("BaseNavigationPage/MasterPage");
          }

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<BaseNavigationPage>();
            containerRegistry.RegisterForNavigation<DetailPage>();
            containerRegistry.RegisterForNavigation<MasterPage>();
          
            containerRegistry.RegisterForNavigation<MasterDetailPageView>();
        }
    }
}
