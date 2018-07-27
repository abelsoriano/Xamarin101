using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using ListXampleFromApiRest.APP.Models;
using ListXampleFromApiRest.APP.Services;

namespace ListXampleFromApiRest.APP.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }

        private ApiServices _apiServices;



        public MainViewModel()
        {
            _apiServices = new ApiServices();


            Employees = new ObservableCollection<Employee>();

            LoadEmployess();

        }

        private async Task LoadEmployess()
        {
            var response = await _apiServices.Get<Employee>("http://listxamplefromapirestbackend.azurewebsites.net/", "api/", "Employees");

            var employees = (List<Employee>)response.Result;

            foreach (var employee in employees)
            {
                Employees.Add(new Employee
                {
                    Address = employee.Address,
                    Email = employee.Email,
                    EmployeeId = employee.EmployeeId,
                    LastName = employee.LastName,
                    Name = employee.Name,
                    Salary = employee.Salary,
                    Tel = employee.Tel
                });

            }
        }
    }
}
