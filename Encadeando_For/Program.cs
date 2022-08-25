using System;

namespace Encadeando_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Encadeamento FOR");

            //*
            //**
            //***
            //****
            //***** Encadeamento For irá realizar operação desejada com break; 

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                         break;                    
                }

                Console.WriteLine();
            }



            Console.WriteLine("Para SAIR pressione ENTER");
            Console.ReadLine();
        }
    }
}
