using System.Collections.ObjectModel;
using EmpList.Models;
using Prism.Navigation;

namespace EmpList.ViewModels
{
    public class EmployeeDetaiilsPageViewModel : ViewModelBase
    {
        private Employee _employee;

        public Employee Employee
        {
            get => _employee;
            set => SetProperty(ref _employee, value);
        }

        public EmployeeDetaiilsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _employee = new Employee();
        }
        
        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            Employee = (Employee)parameters["model"];
        }
    }
}
