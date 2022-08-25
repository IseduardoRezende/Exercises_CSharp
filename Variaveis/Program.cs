using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 2, Criando Variáveis !");
            int idade = 34;

            idade = 34 - 6;
            Console.WriteLine($"Minha idade é {idade}");
            idade = (34 * 5) - 5;
            Console.WriteLine(idade);
            idade = (34 / 5) - 9;
            Console.WriteLine("Eu não tenho " + idade+"R$");

            Console.WriteLine("Digite ENTER para sair");
            Console.ReadLine();
        }
    }
}
