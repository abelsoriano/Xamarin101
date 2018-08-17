using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace mPoketDex.ViewModels
{
	public class MasterPageViewModel : ViewModelBase
	{
        public MasterPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
	}
}
