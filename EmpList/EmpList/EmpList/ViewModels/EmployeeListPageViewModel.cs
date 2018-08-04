using Prism.Commands;
using System.Collections.ObjectModel;
using EmpList.Interfaces;
using EmpList.Models;
using EmpList.Views;
using Prism.Navigation;

namespace EmpList.ViewModels
{
    public class EmployeeListPageViewModel : ViewModelBase
	{
	    private readonly IEmployeeService _employeeService;
	    private readonly INavigationService _navigationService;

	    private ObservableCollection<Employee> _employees;

	    public ObservableCollection<Employee> Employees
	    {
            get { return _employees; }
            set { SetProperty(ref _employees, value); }
	    }

        public EmployeeListPageViewModel(INavigationService navigationService,IEmployeeService employeeService):base(navigationService)
        {
            _employeeService = employeeService;
            _navigationService = navigationService;

            Title = "Employee List";
            Employees= new ObservableCollection<Employee>();

            GetEmployeesFromApi();
            
            NavigateCommand = new DelegateCommand(Navigate);
        }

	    async void Navigate()
	    {
	        var navigationParams = new NavigationParameters();
	        navigationParams.Add("model", selectedEmployee);
            await _navigationService.NavigateAsync("EmployeeDetaiilsPage", navigationParams);
            //   await _navigationService.NavigateAsync(nameof(EmployeeDetaiilsPage) + "/" + selectedEmployee);
          //  await _navigationService.NavigateAsync("EmployeeDetaiilsPage", selectedEmployee);
	    }

        private Employee selectedEmployee;
	    public Employee SelectedEmployee
        {
	        get => selectedEmployee;
	        set => SetProperty(ref selectedEmployee, value);
	    }

	    public DelegateCommand NavigateCommand { get; private set; }
        
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
