using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2026Ej8.Ejercicio6
{
    public class Problema6
    {
        public string NormalizarCodigoProducto(string code)
        {
            if (code == null)
            {
                return "SIN-CÓDIGO";
            }

            return code.ToProductCode();
        }
    }
}
