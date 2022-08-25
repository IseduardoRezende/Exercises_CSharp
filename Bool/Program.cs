using System;

namespace Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Condicional Festa: ");
            int idade = 20;
            int quantPessoa = 3;

            bool acompanhado = quantPessoa > 1;
            bool grupo = true;

            if (idade >= 18 || grupo)
            {
                Console.WriteLine("Entrar");
            }
            else
            {
                Console.WriteLine("Sair");
            }

            Console.ReadLine();
        }
    }
}
