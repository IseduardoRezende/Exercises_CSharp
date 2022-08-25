using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais !");
            int idade = 20;
            int qunatPessoa = 3;
            if (idade >= 18)
            {
                Console.WriteLine("Maior");
            }
            else
            {
                Console.WriteLine("Menor");
            }
            if (qunatPessoa >= 2)
            {
                Console.WriteLine("Acompanhado !");
            }
            else
            {
                Console.WriteLine("não está acompanhado");
            }

            Console.WriteLine("Pressione ENTER para Sair");
            Console.ReadLine();
        }
    }
}
