using System;

namespace Meses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra Mês :)\n");
            Console.WriteLine("Digite o número do mês que está em dúvida: ");

            int mesCondicao = 13;
            int mes = int.Parse(Console.ReadLine());
            if (mesCondicao >= 1 || mesCondicao <=12)
            {
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("O mês é Janeiro");
                        break;
                    case 2:
                        Console.WriteLine("O mês é Fevereiro");
                        break;
                    case 3:
                        Console.WriteLine("O mês é Março");
                        break;
                    case 4:
                        Console.WriteLine("O mês é Abril");
                        break;
                    case 5:
                        Console.WriteLine("O mês é Maio");
                        break;
                    case 6:
                        Console.WriteLine("O mês é Junho");
                        break;
                    case 7:
                        Console.WriteLine("O mês é Julho");
                        break;
                    case 8:
                        Console.WriteLine("O mês é Agosto");
                        break;
                    case 9:
                        Console.WriteLine("O mês é Setembro");
                        break;
                    case 10:
                        Console.WriteLine("O mês é Outubro");
                        break;
                    case 11:
                        Console.WriteLine("O mês é Novembro");
                        break;
                    case 12:
                        Console.WriteLine("O mês é Dezembro");
                        break;
                    default:
                        Console.WriteLine("Não existe este mês º-º");
                        break;
                }
            }
               
            Console.WriteLine("\nPara Sair pressione ENTER");
            Console.ReadLine();
        }
    }
}
