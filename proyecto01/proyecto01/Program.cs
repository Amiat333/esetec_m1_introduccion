using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 * 4 + 10 - 20
            double resultado= Multiplicacion(5, 4);
            resultado = Suma(resultado, 10);
            resultado= Resta(resultado, 20);

            Console.WriteLine(resultado);

            double suma;
            suma = Suma(5.5, 10.5);
            suma = Suma(suma, 30.5);
            double multiplica = Multiplicacion(5, 4);
            double resta = Resta(5.5, 4.5);
            double divide = Division(75.5, 5.5);

            //Mensaje("Hola Mundo Cruel");
            //Mensaje("Adios");
            
            /*
            Console.WriteLine(suma);
            Console.WriteLine(multiplica);
            Console.WriteLine(resta);
            Console.WriteLine(divide);*/
            Console.ReadLine();

        }

        static public void Mensaje(string saludo)
        {
            Console.WriteLine(saludo);
        }

        static public double Suma(double valor1, double valor2)
        {
            //Console.WriteLine(valor1 + valor2);
            return valor1 + valor2;
        }
        static public double Multiplicacion(double valor1, double valor2)
        {
            //Console.WriteLine(valor1 + valor2);
            return valor1 * valor2;
        }
        static public double Resta(double valor1, double valor2)
        {
            //Console.WriteLine(valor1 + valor2);
            return valor1 - valor2;
        }
        static public double Division(double valor1, double valor2)
        {
            //Console.WriteLine(valor1 + valor2);
            return valor1 / valor2;
        }
    }   
}