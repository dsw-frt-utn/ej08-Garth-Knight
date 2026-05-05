using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        private const string _moneda = "AR$";

        private string FormatearPrecio (decimal price)
        {
            return price.ToString("N2");
        }
    }
}
