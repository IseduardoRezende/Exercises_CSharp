using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrada de Festa : !\n");
            Console.WriteLine("Digite a sua idade: ");

            int idade = int.Parse(Console.ReadLine());
            if (idade >=  18)
            {
                Console.WriteLine("Pode entrar na festa :}\n");
            }
            else
            {
                Console.WriteLine("Responda abaixo: ");
            }
            Console.WriteLine("Digite o número de pessoas que estão te acompanhando, caso não houver digite 1 !");
            int quantidadePessoas = int.Parse(Console.ReadLine());
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Pode entrar, aproveite.");
            }
            else
            {
                Console.WriteLine("Menor de idade se retirar, Maior de idade pode entrar");
            }
            
            Console.WriteLine("Para SAIR aperte ENTER");
            Console.ReadLine();
        }
    }
}
