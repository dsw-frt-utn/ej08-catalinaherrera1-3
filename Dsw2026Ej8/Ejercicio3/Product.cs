using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2026Ej8.Ejercicio3
{
    public class Product
    {
        public string Description { get; set; }

        public string SetDescription(string description) => Description = description;
    }
}
