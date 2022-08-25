using System;

namespace Convercao_Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Projeto 6 !");
            double salario = 5000.34;
            int valSalario = (int)salario; //Conversão !

            long x = 2000000000000000000;

            short y = 15000;

            float altura = 1.75f;

            Console.WriteLine("o meu salário é " + valSalario+"R$");
            Console.WriteLine($"minha altura é {altura}");


            Console.WriteLine("Aperte ENTER para sair !");         
            Console.ReadLine();
        }
    }
}
