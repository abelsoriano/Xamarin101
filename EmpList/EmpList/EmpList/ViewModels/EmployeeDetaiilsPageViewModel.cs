using EmpList.Models;
using Prism.Navigation;

namespace EmpList.ViewModels
{
    public class EmployeeDetaiilsPageViewModel : ViewModelBase
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _lastName;

        public string LastName
        {
            get => _lastName;
            set => SetProperty(ref _lastName, value);
        }

        private string _tel;

        public string Tel
        {
            get => _tel;
            set => SetProperty(ref _tel, value);
        }

        private decimal _salary;

        public decimal Salary
        {
            get => _salary;
            set => SetProperty(ref _salary, value);
        }

        private string _address;

        public string Address
        {
            get => _address;
            set => SetProperty(ref _address, value);
        }

        private string _email;

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public EmployeeDetaiilsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _employee = new Employee();
        }

        private Employee _employee;
        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            _employee = (Employee)parameters["model"];

            Name = _employee.Name;
            LastName = _employee.LastName;
            Email = _employee.Email;
            Tel = _employee.Tel;
            Salary = _employee.Salary;
            Address = _employee.Address;
        }
        //public override void OnNavigatedFrom(NavigationParameters parameters)
        //{
        //    _employee = (Employee)parameters["model"];
        //}


    }
}
