using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using EmpList.Models;
using EmpList.Views;
using Xamarin.Forms;

namespace EmpList.ViewModels
{
   public class EmployeeItemViewModel:Employee
    {
        public ICommand SelectEmployeeCommand { get { return new Command(SelectEmployee); } }

        private async void SelectEmployee()
        {
            //var mainViewModel = MainViewModel.GetInstance();
            //mainViewModel.Employees = new EmployeeItemViewModel();
            Application.Current.MainPage = new EmployeeDetaiilsPage();
            //await Application.Current.MainPage.Navigation.PushAsync(new EmployeeDetailsPage(this));

        }
    }
}
