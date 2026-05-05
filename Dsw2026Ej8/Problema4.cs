using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio (int? nota1, int? nota2 , int? nota3)
        {
            int Suma = 0;
            int NotasValidas = 0;

            if (nota1 != null && nota1 <= 10 && nota1 >=0)
            {
                Suma += nota1.Value;
                NotasValidas++;
            }
            if (nota2 != null && nota2 <= 10 && nota2 >= 0)
            {
                Suma += nota2.Value;
                NotasValidas++;
            }
            if (nota3 != null && nota3 <= 10 && nota3 >= 0)
            {
                Suma += nota3.Value;
                NotasValidas++;
            }
            if (NotasValidas == 0) return 0;

            return (double)Suma / NotasValidas;
        }
    }
}
