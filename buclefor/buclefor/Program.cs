using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buclefor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabla = 5, resultado=0;
            /*
            for (int i = 0; i < 11; i++)
            {
                resultado = i * tabla;
                Console.WriteLine(i + " x 5" + " = " + resultado);
            }
            Console.ReadLine(); 

            for (int i = 5; i >= 1; i--)
            {
                resultado = i * resultado;
                
            }*/

            for (int i = 5; i >= 1; i--)
            {
                resultado = i + resultado;

            }

            Console.WriteLine(resultado);
            Console.ReadLine();

            }
        }
    }

