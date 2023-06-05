using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica16
{
    public class Perro : Jugador
    {
        public void Mensaje()
        {
            Console.WriteLine("Hola, soy " + nombre + " el perro jugador");
        }
    }
}
