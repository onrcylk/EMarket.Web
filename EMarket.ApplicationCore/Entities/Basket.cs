using System;
using System.Collections.Generic;
using System.Text;

namespace EMarket.ApplicationCore.Entities
{
    public class Basket
    {
        private readonly List<BasketItem> _items = new List<BasketItem>();

        public IReadOnlyCollection<BasketItem> Items => _items.AsReadOnly();

    }
}
