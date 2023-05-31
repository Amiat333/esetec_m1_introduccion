using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciobucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabla, resultado;
            /*
            for (int i = 0; i < 11; i++)
            {
                tabla = 2;
                resultado = i * tabla;
                Console.WriteLine(i + " x " + tabla + " = " + resultado);

            }
            for (int i = 0; i < 11; i++)
            {
                tabla = 3;
                resultado = i * tabla;
                Console.WriteLine(i + " x " + tabla + " = " + resultado);

            }
            for (int i = 0; i < 11; i++)
            {
                tabla = 4;
                resultado = i * tabla;
                Console.WriteLine(i + " x " + tabla + " = " + resultado);
                
            }
            for (int i = 0; i < 11; i++)
            {
                tabla = 5;
                resultado = i * tabla;
                Console.WriteLine(i + " x " + tabla + " = " + resultado);

            }*/

            for (int i = 1; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.WriteLine(i + " x " + j + " = "  + (j * i));
                }

            }
            Console.ReadLine();

        }
    }
}
