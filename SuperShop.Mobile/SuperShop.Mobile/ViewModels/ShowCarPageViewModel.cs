using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SuperShop.Mobile.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperShop.Mobile.ViewModels
{
    public class ShowCarPageViewModel : ViewModelBase
    {
        public ShowCarPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.ShowShoppingCar;
        }
    }
}
