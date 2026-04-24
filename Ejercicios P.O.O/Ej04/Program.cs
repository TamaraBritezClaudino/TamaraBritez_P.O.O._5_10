using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    //Crear clase Persona con todas las propiedades correctamente encapsuladas.
    public class Persona
    {
        public string Nombre { 
            get; 
            set; 
        }

        private int _edad;

        public int Edad
        {
            get => _edad;
            set
            {
                //Agregar propiedad Edad con validacion 0 a 150.
                if (value >= 0 && value <= 150)
                    _edad = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
