using System;
using Dsw2026Ej8;
using Dsw2026Ej8.Problema1;
using Dsw2026Ej8.Ejercicio2;
using Dsw2026Ej8.Ejercicio3;
using Dsw2026Ej8.Ejercicio4;
using Dsw2026Ej8.Ejercicio5;
using Dsw2026Ej8.Ejercicio6;

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

            //-------------Problema 3-------------
            Problema3 problema3 = new Problema3();

            Product productoPrueba = new Product { Description = "Mouse Óptimo" };
            int originalValue = 100;

            string resultado = problema3.CompararCopias(originalValue, productoPrueba);

            Console.WriteLine("\nEjercicio 3: Descripción");
            Console.WriteLine(resultado);

            //------------- Problema 4 -------------
            Problema4 problema4 = new Problema4();

            int? nota1 = 8;
            int? nota2 = 8;
            int? nota3 = 9;

            double promedio = problema4.CalcularPromedio(nota1, nota2, nota3);

            Console.WriteLine("\nEjercicio 4: Promedio");
            Console.WriteLine($"El promedio es: {promedio:F2}");

            //------------- Problema 5 -------------

            Problema5 problema5 = new Problema5();

            Sale ventaMin = new RetailSale { Importe = 1000m };
            decimal totalRetail = problema5.ObtenerImporteFinal(ventaMin);

            Sale ventaMay = new WholesaleSale { Importe = 1000m };
            decimal totalWholesale = problema5.ObtenerImporteFinal(ventaMay);

            Console.WriteLine("\nEjercicio 5: Total");
            Console.WriteLine($"Venta Minorista: {totalRetail:C}");
            Console.WriteLine($"Venta Mayorista: {totalWholesale:C}");

            //------------- Problema 6 -------------

            Problema6 codigo = new Problema6();

            string ejemplo1 = " ab 123 x";
            string ejemplo2 = null;

            Console.WriteLine("\nEjercicio 6: Conversión");
            Console.WriteLine($"Original: {ejemplo1} - Conversión: {codigo.NormalizarCodigoProducto(ejemplo1)}");
            Console.WriteLine($"Original: {ejemplo2} - Conversión: {codigo.NormalizarCodigoProducto(ejemplo2)}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
