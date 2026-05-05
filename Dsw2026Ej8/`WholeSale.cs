using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class WholeSale : Sale
    {
        public WholeSale(decimal price) : base(price)
        {
        }

        public override decimal CalculateTotal()
        {
            return base.Price * 0.9m;
        }
    }
}
