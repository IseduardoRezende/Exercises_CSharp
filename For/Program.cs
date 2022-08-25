using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador !");

            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }

            Console.WriteLine("Para sair pressione ENTER");
            Console.ReadLine();
        }
    }
}
