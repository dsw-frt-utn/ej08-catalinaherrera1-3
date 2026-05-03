using System;
using Dsw2026Ej8;
using Dsw2026Ej8.Problema1;
using Dsw2026Ej8.Ejercicio2;

namespace Dsw2026Ej8
{
     class Program
    {
        static void Main(string[] args)
        {
            //------------ Problema 1 ------------
            ProductHelper product = new ProductHelper();

            long code = 2005;
            string description = "ACER Ryzen 7";
            decimal price = 1500.10m;

            string etiqueta = product.ObtenerEtiquetaProducto(code, description, price);

            Console.WriteLine("Ejercicio 1: Etiqueta");
            Console.WriteLine(etiqueta);

            //------------ Problema 2 ------------
            Problema2 venta = new Problema2();

            long productCode = 1223;
            string productDescription = "Teclado Inalámbrico";
            int quantity = 3;
            decimal unitPrice = 899.00m;

            string resumen = venta.CrearResumenVenta(productCode, productDescription, quantity, unitPrice);

            Console.WriteLine("\nEjercicio 2: Resumen");
            Console.WriteLine(resumen);

            //------------ Problema 3 ------------

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
