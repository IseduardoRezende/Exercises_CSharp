using System;

namespace Atribuições_Variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atribuições a variáveis !");

            int idade = 16;
            int idadeEdu = idade;

            Console.WriteLine(idadeEdu);

            idade = 17;
            Console.WriteLine(idade);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
