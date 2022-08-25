using System;

namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Efetuando Condicional");
            int idade = 16;
            int qtdPessoa = 2;

            bool acompanhado = qtdPessoa > 1;

            string txtAdicional;
            if (acompanhado == true)
            {
               txtAdicional = "Acompanhado";
            }
            else
            {
                txtAdicional = "Não acompanhado";
            }

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine(txtAdicional);
                Console.WriteLine("Entra");
            }
            else
            {
                Console.WriteLine("Não entra");
            }

            Console.Write("Presssione ENTER para Sair");
            Console.ReadLine();
        }
    }
}
