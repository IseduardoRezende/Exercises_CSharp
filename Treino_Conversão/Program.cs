using System;

namespace Treino_Conversão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            float pontoFlutuante = 3.14f; 

            double salario = 1270.50;
            int valor = (int)salario;

            double val1 = 1.5;
            double val2 = 1.5;
            double total = val1 + val2;
            Console.WriteLine(total);

            Console.WriteLine(pontoFlutuante);
            Console.WriteLine(valor);
            Console.WriteLine("Digite ENTER para Sair !");
            Console.ReadLine();
        }
    }
}
