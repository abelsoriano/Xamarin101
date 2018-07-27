using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListXampleFromApiRest.APP.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListXampleFromApiRest.APP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmployeeDetailsPage : ContentPage
	{

		public EmployeeDetailsPage (EmployeeItemViewModel employee)
		{
			InitializeComponent ();
            var empvm = new EmployeeDetailsViewModel(employee);
		    BindingContext = empvm;
		}
	}
}