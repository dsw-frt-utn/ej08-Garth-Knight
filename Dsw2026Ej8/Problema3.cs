using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias( int originalValue, Product product)
        {
            int CopyValue=originalValue;
            CopyValue++;
            Product Reference = product;
            Reference.Description = "Copia";
            return $"{originalValue}-{CopyValue}-{Reference.Description}";
        }
    }
}
