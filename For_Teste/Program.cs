using System;

namespace For_Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encadeamento !\n");

            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if (coluna > linha)
                         break;                    

                    Console.WriteLine(coluna + 1);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Para sair pressione ENTER");
            Console.ReadLine();
        }
    }
}
