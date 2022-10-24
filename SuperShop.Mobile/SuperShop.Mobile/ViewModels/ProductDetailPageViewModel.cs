﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SuperShop.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperShop.Mobile.ViewModels
{
    public class ProductDetailPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private ProductResponse _product;


        public ProductDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
        }

        public ProductResponse Product
        {
            get => _product;
            set => SetProperty(ref _product, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("product"))
            {
                Product = parameters.GetValue<ProductResponse>("product");
                Title = Product.Name;
            }
        }
    }
}