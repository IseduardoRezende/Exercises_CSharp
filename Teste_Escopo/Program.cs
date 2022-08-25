using System;

namespace Teste_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais!");

            int idade = 20;
            int qtdPessoa = 3;

            //bool acompanhamento = true;
            bool acompanhado;
            
            if (qtdPessoa >= 2)
            {
                acompanhado = true;
            }
            else
            {
                acompanhado = false;
            }

            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Seja bem vindo !");
            }
            else
            {
                Console.WriteLine("Não é possível entrar");
            }

            Console.ReadLine();
        }
    }
}
