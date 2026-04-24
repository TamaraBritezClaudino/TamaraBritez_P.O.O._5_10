using System;

namespace Ej03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Usar const para IVA = 0.21m.
            decimal IVA = 0.21m;
            decimal precio = 500;
            decimal total = precio + (precio * IVA);

            Console.WriteLine($"Precio con IVA aplicado: ${total}");
        }
    }
}
