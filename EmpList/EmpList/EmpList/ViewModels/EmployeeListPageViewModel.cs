using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EmpList.Interfaces;
using EmpList.Models;
using Prism.Navigation;

namespace EmpList.ViewModels
{
	public class EmployeeListPageViewModel : ViewModelBase
	{
	    private readonly IEmployeeService _employeeService;

	    private ObservableCollection<Employee> _employees;

	    public ObservableCollection<Employee> Employees
	    {
            get { return _employees; }
            set { SetProperty(ref _employees, value); }
	    }

        public EmployeeListPageViewModel(INavigationService navigationService,IEmployeeService employeeService):base(navigationService)
        {
            _employeeService = employeeService;
            Title = "Employee List";
            Employees= new ObservableCollection<Employee>();

            GetEmployeesFromApi();
        }

        async void GetEmployeesFromApi()
        {
            IsRunning = true;
            var result = await _employeeService.GetAllEmployees();
            IsRunning = false;

            foreach (var item in result)
            {
                Employees.Add(item);
            }
        }
    }
}
