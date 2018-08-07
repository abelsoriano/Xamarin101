using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using EmpList.Models;
using Prism.Navigation;

namespace EmpList.ViewModels
{
	public class BeerDetailsPageViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private Beer beer;

        public Beer Beer
        {
            get => beer;
            set => SetProperty(ref beer, value);
        }

        public BeerDetailsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            beer = new Beer();
            _beer = new Beer();
        }

        private Beer _beer;
        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            _beer = (Beer)parameters["model"];

            beer.Name = _beer.Name;
            //employee.LastName = _employee.LastName;
            //employee.Email = _employee.Email;
            //employee.Tel = _employee.Tel;
            //employee.Salary = _employee.Salary;
            //employee.Address = _employee.Address;
        }
    }
}
