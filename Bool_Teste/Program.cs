using System;

namespace Bool_Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais!");

            int idade = 16;
            int qtdPessoa = 3;
            bool acompanhado = qtdPessoa >=2;

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo !");
            }
            else
            {
                Console.WriteLine("Infelizmente você não entra");
            }

            Console.ReadLine();
        }
    }
}
