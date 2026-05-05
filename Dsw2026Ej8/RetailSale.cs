using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class RetailSale : Sale
    {
        public RetailSale(decimal price) : base(price)
        {
        }

        public override decimal CalculateTotal()
        {
            return base.Price;
        }
    }
}
