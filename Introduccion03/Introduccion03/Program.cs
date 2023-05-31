using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Introduccion03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;

            numero1 = 30;
            numero2 = 20;

            if(numero1 > numero2)
            {
                Console.WriteLine("El número 1 es mayor que el número 2");
            } else
            {
                Console.WriteLine("El número 1 no es mayor");
            }

            resultado= numero1 * numero2;

            Console.WriteLine(numero1 + " * " + numero2 + " = " + resultado);
            Console.ReadLine();

        }
    }
}
