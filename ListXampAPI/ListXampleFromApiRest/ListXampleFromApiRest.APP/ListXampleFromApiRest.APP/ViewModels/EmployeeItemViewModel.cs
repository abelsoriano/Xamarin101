using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ListXampleFromApiRest.APP.Models;
using ListXampleFromApiRest.APP.Views;
using Xamarin.Forms;

namespace ListXampleFromApiRest.APP.ViewModels
{

    public class EmployeeItemViewModel : Employee
    {
        public ICommand SelectEmployeeCommand { get { return new Command(SelectEmployee); } }

        private async void SelectEmployee()
        {
            //var mainViewModel = MainViewModel.GetInstance();
            //mainViewModel.Employees = new EmployeeItemViewModel();
            Application.Current.MainPage = new EmployeeDetailsPage(this);
            //await Application.Current.MainPage.Navigation.PushAsync(new EmployeeDetailsPage(this));

        }
        //private EmployeeItemViewModel employee;

        //public EmployeeItemViewModel(EmployeeItemViewModel employee)
        //{
        //    this.employee = employee;
        //}
    }
}
