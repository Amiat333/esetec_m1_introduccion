using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica16
{
    public class Jugador
    {
        public string nombre;
        public int puntuacion;

        public void SetPuntuacion(int puntos)
        {
            puntuacion = puntuacion + puntos;
        }

        public void ImprimirJugador()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Puntuación: " + puntuacion);
        }

        public virtual void Mensaje()
        {
            Console.WriteLine("Soy un Jugador");
        }

    }
}
