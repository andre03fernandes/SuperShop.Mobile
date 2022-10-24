using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SuperShop.Mobile.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperShop.Mobile.ViewModels
{
    public class ModifyUserPageViewModel : ViewModelBase
    {
        public ModifyUserPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.ModifyUser;
        }
    }
}
