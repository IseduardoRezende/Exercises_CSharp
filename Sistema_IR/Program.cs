using System;

namespace Sistema_IR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema IR !");

            Console.WriteLine("Informe o seu salário:\n ");

            double salario = double.Parse(Console.ReadLine());
            if (salario < 0 || salario <= 1899.9)
            {
                Console.WriteLine("Valor Incompreendido");
            }
            else if (salario == 1900.0 || salario <= 2800.0)
            {
                Console.WriteLine("A sua eliquota é de 7.5%\nPode deduzir R$ 142");
            } 
            else if (salario >= 2800.01 || salario <= 3751.0)
            {
                Console.WriteLine("A sua eliquota é de 15%\nPode deduzir R$ 350");
            }
            else if (salario >= 3751.01 || salario == 4664.00 )
            {
                Console.WriteLine("A sua eliquota é de 22.5%\nPode deduzir R$ 636");
            }
            else
                Console.WriteLine("Valor Incompreendido");


            Console.WriteLine("\nObrigado !\nPara Sair pressione ENTER ");
            Console.ReadLine();
        }
    }
}
