using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2026Ej8.Ejercicio6
{
    public static class Extensions
    {
        public static string ToProductCode(this string value)
        {
            if (value == null)
            {
                return null;
            }

            return value.Trim()              // Elimina espacios inicio/final
                        .ToUpper()           // Convierte a mayúsculas
                        .Replace(" ", "-");  // Reemplaza espacios internos por guiones
        }
    }
}
