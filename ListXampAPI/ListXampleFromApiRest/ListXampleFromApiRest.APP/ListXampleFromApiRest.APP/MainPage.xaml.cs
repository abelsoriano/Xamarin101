using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListXampleFromApiRest.APP.ViewModels;
using Xamarin.Forms;

namespace ListXampleFromApiRest.APP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext= new MainViewModel();
		}
	}
}
