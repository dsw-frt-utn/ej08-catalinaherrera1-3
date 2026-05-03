using Dsw2026Ej8.Problema1;

namespace Dsw2026Ej8
{
    internal class Program
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
        }
    }
}
