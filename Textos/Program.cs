using System;

namespace Textos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Atividade Text !");

            char letra = 'e';
            Console.WriteLine(letra);
            char valor = (char)65;
            Console.WriteLine(valor);

            valor = (char)(valor + 1);  //Convertendo para Char toda as expressões !
            Console.WriteLine(valor);

            string palavra = "Alura ";
            palavra = palavra + 2022;
            Console.WriteLine(palavra);
            
            Console.WriteLine("Para sair digite ENTER !");
            Console.ReadLine();
        }
    }
}
