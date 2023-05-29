using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valor1, valor2;
            float resultado;

            Console.WriteLine("Introduce el precio total de la cuenta; ");
            valor1 = Console.ReadLine();

            Console.WriteLine("Introduce el número de personas que van a realizar el pago; ");
            valor2 = Console.ReadLine();

            resultado = Convert.ToSingle(valor1) / Convert.ToSingle(valor2);
            Console.WriteLine(valor1 + " / " + valor2 + " = " + resultado);
            Console.WriteLine("Toca a pagar la siguiente cantidad por persona: " + resultado);

            Console.WriteLine("Presiona Enter para salir");
            Console.ReadLine();

            /*
            Console.WriteLine("Introduce el precio total de la cuenta: ");
            valor1 = Console.ReadLine();

            Console.WriteLine("Introduce el número de personas que van a realizar el pago: ");
            valor2 = Console.ReadLine();

            if (float.TryParse(valor1, out float precio) && float.TryParse(valor2, out float personas))
            {
                resultado = precio / personas;
                Console.WriteLine(valor1 + " / " + valor2 + " = " + resultado);
                Console.WriteLine("Toca a pagar la siguiente cantidad por persona: " + resultado);
            }
            else
            {
                Console.WriteLine("El valor introducido no es válido. Por favor, introduce un número válido.");
            }

            Console.WriteLine("Presiona Enter para salir");
            Console.ReadLine(); */
        }
    }
}
