using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto02
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
           

            MiNota();

        }

        static public void MiNota()
        {
            /* 0 al 4 = Suspendido
             * 5 al 6 = Aprobado
             * 7 al 8 = Notable
             * 9 al 10 = Sobresaliente */

            string nota;
            Console.WriteLine("Introduce una Nota");
            nota = Console.ReadLine();


            


            if (float.TryParse(nota, out float salida))
            {
                
                if (salida <= 4)
                {
                    Console.WriteLine("Está Suspendido");
                }

                if (salida >= 5 && salida <= 6)
                {
                    Console.WriteLine("Está aprobado");
                }

                if (salida >= 7 && salida <= 8)
                {
                    Console.WriteLine("Está aprobado con Notable");
                }

                if (salida >= 9 && salida <= 10)
                {
                    Console.WriteLine("!Sobresaliente¡");
                }
                else if (salida >= 11)
                {
                    Console.WriteLine("El valor Introducido no es válido");
                }
            }
            else
            {
                Console.WriteLine("El valor introducido no es válido. Por favor, introduce un número válido.");
            }

                

            Console.ReadLine();
        }

        static public void GetMiNota ()
        {
            string nota;
            double resultado;
            Console.WriteLine("Introduce una Nota");
            nota = Console.ReadLine();
            resultado = Convert.ToSingle(nota);


            string notaString = "";
            switch (resultado)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    notaString = "Suspendido";
                    break;
                case 5:
                case 6:
                    notaString = "Aprobado";
                    break;
                case 7:
                case 8:
                    notaString = "Aprobado con Notable";
                    break;
                case 9:
                case 10:
                    notaString = "!Sobresaliente¡";
                    break;
                default:
                    notaString = "Caracter no válido";
                    break;
            }
            Console.WriteLine(notaString);
            Console.ReadLine();
        }
    }
}
