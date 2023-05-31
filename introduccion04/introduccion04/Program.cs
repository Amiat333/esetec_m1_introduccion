using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccion04
{
    internal class Program
    {
        //Dado la edad de una persona decir si es mayor de edad o no.
        static void Main(string[] args)
        {
            string edad;
            float resultado;

            Console.WriteLine("Introduce una edad");
            edad = Console.ReadLine();

            resultado = Convert.ToSingle(edad);

            if (resultado <= 12 && resultado < 18)
            {
                Console.WriteLine("Eres un niño pequeño");

            }

            if (resultado > 12 && resultado < 18)
            {
                Console.WriteLine("Eres un adolescente");

            } else if (resultado > 18)

            {
                Console.WriteLine("Eres mayor de edad");

            }
            Console.ReadLine();
        }

    }
}
