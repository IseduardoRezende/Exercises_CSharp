using System;

namespace Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Textos e caracteres!");

            char letra = 'e';   //Apenas Aspas Simples em variáveis tipo Char;
            Console.WriteLine(letra);

            letra = (char)65;
            Console.WriteLine(letra);

            letra = (char)(56 + 8);
            Console.WriteLine(letra);

            string ola = "Estou fazendo cursos na Alura ! ";
            Console.WriteLine(ola + 2022);

            //string cursos = @"Cursos disponíveis: 
            // - Go 
            // - C# 
            // - Python
            // - Java ";

            string cursos = "Cursos Disponíveis:\n- Java\n- C#\n- Python";

            Console.WriteLine(cursos);

            Console.WriteLine("Aperte ENTER para Sair !");
            Console.ReadLine();
        }
    }
}
