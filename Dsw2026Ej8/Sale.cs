using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Sale
    {
        private decimal _price;

        public Sale(decimal price)
        {
            _price = price;
        }

        public decimal Price { get => _price; set => _price = value; }

        public virtual decimal CalculateTotal()
        {
            return 0;
        }
    }
}
