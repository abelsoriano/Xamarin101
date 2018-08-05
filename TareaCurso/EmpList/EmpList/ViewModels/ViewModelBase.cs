using Prism.Mvvm;
using Prism.Navigation;

namespace EmpList.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private bool _isRunning;
        private bool _isNotRunning = true;

        public bool IsRunning
        {
            get => _isRunning;
            set {
                SetProperty(ref _isRunning, value);
                SetProperty(ref _isNotRunning, !value);
            }
        }

        public bool IsNotRunning
        {
            get => _isNotRunning;
            set => SetProperty(ref _isNotRunning, value);
        }



        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }

        public virtual void Destroy()
        {
            
        }
    }
}
