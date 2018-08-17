using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PoketDex.ViewModels
{
	public class FavoritePageViewModel : ViewModelBase
	{
        public FavoritePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "My Favorites Pokemons";
        }
	}
}
