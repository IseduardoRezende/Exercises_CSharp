using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laços de Repetições :}");

            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine(contador);                
                contador++;
            }            

            Console.WriteLine("Para SAIR pressione ENTER");
            Console.ReadLine();
        }
    }
}
