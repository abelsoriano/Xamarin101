using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using ListXampleFromApiRest.APP.Models;
using ListXampleFromApiRest.APP.Views;

namespace ListXampleFromApiRest.APP.ViewModels
{
   public class EmployeeDetailsViewModel:Employee, INotifyPropertyChanged
    {
        // private Employee _employee;
        //private string _name;

        //public string Name
        //{
        //    set {
        //        if (_name == value) return;
        //        _name = value;
        //        if (PropertyChanged != null) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
        //    }
        //    get => _name;
        //}

        //private string _lastName;

        //public string LastName
        //{
        //    set {
        //        if (_lastName == value) return;
        //        _lastName = value;
        //        if (PropertyChanged != null) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LastName"));
        //    }
        //    get => _lastName;
        //}

        //private string _tel;

        //public string Tel
        //{
        //    set {
        //        if (_tel == value) return;
        //        _tel = value;
        //        if (PropertyChanged != null) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tel"));
        //    }
        //    get => _tel;
        //}

        //private decimal _salary;

        //public decimal Salary
        //{
        //    set {
        //        if (_salary == value) return;
        //        _salary = value;
        //        if (PropertyChanged != null) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Salary"));
        //    }
        //    get => _salary;
        //}

        //private string _address;

        //public string Address
        //{
        //    set {
        //        if (_address == value) return;
        //        _address = value;
        //        if (PropertyChanged != null) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Address"));
        //    }
        //    get => _address;
        //}

        //private string _email;

        //public string Email
        //{
        //    set {
        //        if (_email == value) return;
        //        _email = value;
        //        if (PropertyChanged != null) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email"));
        //    }
        //    get => _email;
        //}

       
        public EmployeeDetailsViewModel(Employee employee)
        {
           // _employee = employee;

            Name = employee.Name;
            LastName = employee.LastName;
            Email = employee.Email;
            Tel = employee.Tel;
            Salary =   employee.Salary;
            Address = employee.Address;

        
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
