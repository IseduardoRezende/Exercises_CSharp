using System;

namespace Calcula_Poupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálcula Poupança");

            double investimento = 1000;

            //Rendimento de 0.5% (0.005) ao mês;

            //investimento = investimento + investimento * 0.005;
            //investimento = investimento + investimento * 0.005;
            //investimento = investimento + investimento * 0.005;

            int mes = 1;
            while (mes <= 12)
            {
                investimento = investimento + investimento * 0.005;
                Console.WriteLine("No mês " + mes + " você possui R$ " + investimento);

                mes +=1;
            }

            Console.WriteLine("Pressione Enter para Sair");
            Console.ReadLine();
        }
    }
}
