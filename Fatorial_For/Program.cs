using System;

namespace Fatorial_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial do 1 ao 10 !");

            int fatorial = 1;
            int num = 1;

            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
          
            Console.WriteLine("===================");

            Console.WriteLine("pressione ENTER para Sair");
            Console.ReadLine();
            }
        }
    }
