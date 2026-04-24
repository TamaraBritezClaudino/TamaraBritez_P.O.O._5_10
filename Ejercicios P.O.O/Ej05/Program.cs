using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05
{
    //Crear propiedad calculada: Perimetro => 2 * (Ancho + Alto).
    public class Rectangulo
    {
        public double Ancho { 
            get;
            set;
        }
        
        public double Alto { 
            get;
            set;
        }

        public double Perimetro => 2 * (Ancho + Alto);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rec = new Rectangulo();

            rec.Ancho = 20;
            rec.Alto = 10;

            Console.WriteLine($"Perímetro: {rec.Perimetro}cm");
        }
    }
}
