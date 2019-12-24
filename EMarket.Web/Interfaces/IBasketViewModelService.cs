﻿using EMarket.ApplicationCore.Entities;
using EMarket.ApplicationCore.Interfaces;
using EMarket.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Web.Interfaces
{
    public interface IBasketViewModelService
    {

        void AddToBasket(int product, int quantity = 1);
        IReadOnlyCollection<BasketItem> GetBasketItems();

        int TotalItems();

        HeaderCartViewModel GetHeaderCartViewModel();

    }

}
