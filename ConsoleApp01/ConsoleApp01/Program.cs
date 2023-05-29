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
            Console.WriteLine("Entra el primer número para la suma; ");
            valor1 = Console.ReadLine();

            Console.WriteLine("Entra el segundo número para la suma; ");
            valor2 = Console.ReadLine();

            resultado= Convert.ToInt32(valor1) + Convert.ToInt32(valor2);
            Console.WriteLine(valor1 + " + " + valor2 + " = " + resultado);

            Console.WriteLine("Entra el primer número para la resta; ");
            valor1 = Console.ReadLine();

            Console.WriteLine("Entra el segundo número para la resta; ");
            valor2 = Console.ReadLine();

            resultado = Convert.ToInt32(valor1) - Convert.ToInt32(valor2);
            Console.WriteLine(valor1 + " - " + valor2 + " = " + resultado);

            Console.WriteLine("Entra el primer número para la multiplicación; ");
            valor1 = Console.ReadLine();

            Console.WriteLine("Entra el segundo número para la multiplicación; ");
            valor2 = Console.ReadLine();

            resultado = Convert.ToInt32(valor1) * Convert.ToInt32(valor2);
            Console.WriteLine(valor1 + " * " + valor2 + " = " + resultado);

            Console.WriteLine("Entra el primer número para la división; ");
            valor1 = Console.ReadLine();

            Console.WriteLine("Entra el segundo número para la división; ");
            valor2 = Console.ReadLine();

            resultado = Convert.ToInt32(valor1) / Convert.ToInt32(valor2);
            Console.WriteLine(valor1 + " / " + valor2 + " = " + resultado);

            Console.WriteLine("Presiona Enter para salir");
            Console.ReadLine();

       
            string nombre;
            string edad;

            Console.WriteLine("Escribe tu nombre ");
            nombre= Console.ReadLine();

            Console.WriteLine("Escribe tu edad ");
            edad = Console.ReadLine();

            Console.WriteLine("Tu nombre es " + nombre);

            Console.WriteLine("Y tu edad es " + edad);

            Console.WriteLine("Presiona Enter para salir");
            Console.ReadLine();
            */
        }
    }
}
