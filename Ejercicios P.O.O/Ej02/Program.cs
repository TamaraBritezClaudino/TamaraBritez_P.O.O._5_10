using System;

namespace Ej02
{
    //Crear clase Temperatura con propiedad que valide > -273.
    public class Temperatura
    {
        private double _grados;

        public double grados
        {
            get => _grados;
            set
            {
                if (value > -273)
                    _grados = value;

                else
                    Console.WriteLine("Temperatura inválida");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temp = new Temperatura();

            Console.Write("Ingrese una temperatura: ");
            double valor = double.Parse(Console.ReadLine());

            temp.grados = valor;

            Console.WriteLine($"La temperatura ingresada es: {temp.grados}°C");
        }
    }
}
