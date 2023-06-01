using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dibujoBaseConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Metodo2();

            Console.ReadLine();
        }

        static public void Metodo1()
        {
            Console.WriteLine("XXXXXXXX");
            Console.WriteLine("X      X");
            Console.WriteLine("X      X");
            Console.WriteLine("X      X");
            Console.WriteLine("XXXXXXXX");
        }

        static public void Metodo2()
        {
           for (int i = 0; i <= 9; i++)
            {

                for (int j = 0; j <= 9; j++)
                {
                    if (j == 0 || j == 9)
                    {
                        Console.Write("X");
                    }
                    
                    if (i == 0 || i == 9)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
        
    

