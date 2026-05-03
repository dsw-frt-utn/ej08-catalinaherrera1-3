using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2026Ej8.Ejercicio2
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total;

            if (quantity > 0) { 
                total = quantity * unitPrice;
            }
            else
            {
                 total = 0;
            }

            var ventaAnonymous = new { Code = productCode, Description = productDescription, Quantity = quantity, Total = total };

            return $"{ventaAnonymous.Code}-{ventaAnonymous.Description}-{ventaAnonymous.Total}";
        }
    }
}
