using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta (long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            var datos = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = quantity > 0 ? quantity * unitPrice : 0
            };

            return $"{datos.Code}-{datos.Description}-{datos.Total}";
        }
    }
}
