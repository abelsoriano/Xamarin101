using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ListXampleFromApiRest.APP.Models;
using ListXampleFromApiRest.APP.Services;
using ListXampleFromApiRest.APP.Views;
using Xamarin.Forms;

namespace ListXampleFromApiRest.APP.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private static MainViewModel _instance;

        public static MainViewModel GetInstance()
        {
            return _instance ?? (_instance = new MainViewModel());
        }
        //   public ObservableCollection<EmployeeItemViewModel> Employees { get; set; }

        private ApiServices _apiServices;

        private string _lblText;

        private ObservableCollection<EmployeeItemViewModel> _employees;
        public ObservableCollection<EmployeeItemViewModel> Employees
        {
            get => _employees;
            set {
                _employees = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Employee"));

            }
        }
        public string LblText
        {
            set {
                if (_lblText == value) return;
                _lblText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LblText"));
            }
            get => _lblText;
        }



        public MainViewModel()
        {
            _apiServices = new ApiServices();


            Employees = new ObservableCollection<EmployeeItemViewModel>();

            LoadEmployess();

        }

        


        private async Task LoadEmployess()
        {
            var response = await _apiServices.Get<Employee>("http://listxamplefromapirestapi.azurewebsites.net/", "api/", "Employees");

            var employees = (List<Employee>)response.Result;

            foreach (var employee in employees)
            {
                Employees.Add(new EmployeeItemViewModel
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
            LblText = "Empleados felices";

        }
        public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
