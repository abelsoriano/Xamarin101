using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PoketDex.ViewModels
{
	public class PokemonListViewModel : ViewModelBase
	{
        public PokemonListViewModel(INavigationService navigationService): base(navigationService)
        {
            Title = "Pokemon List";
        }
	}
}
