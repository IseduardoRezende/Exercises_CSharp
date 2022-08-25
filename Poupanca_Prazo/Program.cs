using System;

namespace Poupanca_Prazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Poupança Longo Prazo");

            double fatorRendimento = 1.005;
            double valorInvestimento = 1000;

            for (int anos = 1; anos <= 5; anos++)
            {
                for (int mes = 1; mes <= 12; mes++)  //Encadeamnto, Laços "For";
                {
                    valorInvestimento *= fatorRendimento;
                    Console.WriteLine("No mês " + mes + " você ganhou " + valorInvestimento + " R$");
                }

                fatorRendimento += 0.001;
            }

            Console.WriteLine("Em cinco anos você terá " + valorInvestimento + " R$");

            Console.WriteLine("Para fechar pressione ENETER !");
            Console.ReadLine();
        }
    }
}
