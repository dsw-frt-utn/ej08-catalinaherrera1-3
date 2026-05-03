using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2026Ej8.Ejercicio4
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma = 0;
            int contador = 0;

            if (nota1 != null && nota1 >= 0 && nota1 <= 10)
            {
                suma += (int)nota1;
                contador++;
            }

            if (nota2 != null && nota2 >= 0 && nota2 <= 10)
            {
                suma += (int)nota2;
                contador++;
            }

            if (nota3 != null && nota3 >= 0 && nota3 <= 10)
            {
                suma += (int)nota3;
                contador++;
            }

            if (contador == 0)
            {
                return 0;
            }

            return (double)suma / contador;

        }
    }
}
