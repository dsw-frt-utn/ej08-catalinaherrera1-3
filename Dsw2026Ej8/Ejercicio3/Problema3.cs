using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2026Ej8.Ejercicio3
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copyValue = originalValue;
            copyValue++;

            Product copyProduct = product;
            copyProduct.SetDescription("Descripción Modificada");

            return $"{originalValue}-{copyValue}-{copyProduct.Description}";
        }
    }
}
