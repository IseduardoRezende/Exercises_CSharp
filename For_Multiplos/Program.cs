using System;

namespace For_Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Multiplos de 3 entre 1 e 100 !");

            for (int multiplo = 3; multiplo < 100; multiplo += 3)
            {
                Console.WriteLine(multiplo);
            }

            Console.WriteLine("===============");

            for (int multiplicador = 5; multiplicador < 100; multiplicador+= 5)
            {
                Console.WriteLine(multiplicador);
            }

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }

                    Console.WriteLine(coluna + 1);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Para sair selecione ENTER");
            Console.ReadLine();
        }
    }
}
