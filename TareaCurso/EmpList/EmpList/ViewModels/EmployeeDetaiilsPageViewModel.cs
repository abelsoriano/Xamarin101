using System.Collections.ObjectModel;
using EmpList.Models;
using Prism.Navigation;

namespace EmpList.ViewModels
{
    public class EmployeeDetaiilsPageViewModel : ViewModelBase
    {
        private Employee employee;

        public Employee Employee
        {
            get => employee;
            set => SetProperty(ref employee, value);
        }
        //private string _name;

        //public string Name
        //{
        //    get => _name;
        //    set => SetProperty(ref _name, value);
        //}

        //private string _lastName;

        //public string LastName
        //{
        //    get => _lastName;
        //    set => SetProperty(ref _lastName, value);
        //}

        //private string _tel;

        //public string Tel
        //{
        //    get => _tel;
        //    set => SetProperty(ref _tel, value);
        //}

        //private decimal _salary;

        //public decimal Salary
        //{
        //    get => _salary;
        //    set => SetProperty(ref _salary, value);
        //}

        //private string _address;

        //public string Address
        //{
        //    get => _address;
        //    set => SetProperty(ref _address, value);
        //}

        //private string _email;

        //public string Email
        //{
        //    get => _email;
        //    set => SetProperty(ref _email, value);
        //}

        public EmployeeDetaiilsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            employee = new Employee();
            _employee = new Employee();
        }

         private Employee _employee;
        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            _employee = (Employee)parameters["model"];

            employee.Name = _employee.Name;
            employee.LastName = _employee.LastName;
            employee.Email = _employee.Email;
            employee.Tel = _employee.Tel;
            employee.Salary = _employee.Salary;
            employee.Address = _employee.Address;
        }
        //public override void OnNavigatedFrom(NavigationParameters parameters)
        //{
        //    _employee = (Employee)parameters["model"];
        //}


    }
}
