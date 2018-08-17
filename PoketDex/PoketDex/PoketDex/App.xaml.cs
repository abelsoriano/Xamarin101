using Prism;
using Prism.Ioc;
using PoketDex.ViewModels;
using PoketDex.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PoketDex
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

            await NavigationService.NavigateAsync("BaseNavigationPage/MasterPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            //containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<MasterPage>();
            //containerRegistry.RegisterForNavigation<MyNavigationPage>();
            //containerRegistry.RegisterForNavigation<MasterPageView>();
            //containerRegistry.RegisterForNavigation<MasterPage>();
            containerRegistry.RegisterForNavigation<Xamarin.Forms.MasterDetailPage>();
            //containerRegistry.RegisterForNavigation<MasterDetailPage>();
            containerRegistry.RegisterForNavigation<BaseNavigationPage>();
            containerRegistry.RegisterForNavigation<DetailPage>();

            //containerRegistry.RegisterTypeForNavigation<MasterDetailPageView, MasterDetailPageViewModel>();
            //Container.RegisterTypeForNavigation<MasterPageView, MasterPageViewModel>();
            //Container.RegisterTypeForNavigation<DetailPageView, DetailPageViewModel>();
            //Container.RegisterTypeForNavigation<BaseNavigationPageView, BaseNavigationPageViewModel>();
        }
    }
}
