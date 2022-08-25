using System;

namespace Calcula_PoupancaTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálcula Poupança pelo For !");

            double investimento = 1000;

            for (int mes = 1; mes <= 12; mes ++)
            {
                investimento *= 1.005;
                Console.WriteLine(" no mês " + mes + " você possui " + investimento +" R$");
            }

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
