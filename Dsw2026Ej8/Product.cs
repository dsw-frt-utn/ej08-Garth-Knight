using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Product
    {
        private int _originalValue;
        private string _description;

        public Product(int originalValue, string description)
        {
            _originalValue = originalValue;
            _description = description;
        }

        public int OriginalValue { get => _originalValue; set => _originalValue = value; }
        public string Description { get => _description; set => _description = value; }
    }
}
