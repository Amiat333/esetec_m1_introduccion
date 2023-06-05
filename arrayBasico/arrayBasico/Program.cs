using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayBasico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroAlumnos = 30;
            int [] notas= new int[numeroAlumnos];
            int suma = 0;

            notas[0] = 4;
            notas[1] = 5;
            notas[2] = 6;
            notas[3] = 8;
            notas[4] = 9;

            for (int i = 0; i < numeroAlumnos; i++)
            {
                suma = suma + notas[i];
            }

            Console.WriteLine(suma);
            Console.ReadLine();
           

        }
    }
}
