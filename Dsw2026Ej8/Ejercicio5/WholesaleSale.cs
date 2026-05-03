using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2026Ej8.Ejercicio5
{
    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Importe * 0.90m;
        }
    }
}
