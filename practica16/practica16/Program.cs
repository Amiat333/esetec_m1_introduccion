using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica16
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Jugador jugador = new Jugador();
            jugador.nombre = "Ernesto";
            jugador.puntuacion = 0;

            jugador.SetPuntuacion(random.Next(10+1));

            jugador.Mensaje();
            jugador.ImprimirJugador();
            Console.ReadLine();

            Perro perro= new Perro();
            perro.nombre = "Layca";
            perro.puntuacion = 0;

            int puntos = random.Next(10+1);
            perro.SetPuntuacion(puntos);

            perro.Mensaje();
            perro.ImprimirJugador();
            Console.ReadLine();

            Gato gato = new Gato();
            gato.nombre = "Misifú";
            gato.puntuacion= 0;

            gato.SetPuntuacion(random.Next(10+1));

            gato.Mensaje();
            gato.ImprimirJugador();
            Console.ReadLine();

            
            
            
        }
    }
}
