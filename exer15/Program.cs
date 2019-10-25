using System;

namespace exer14
{
    class Program
    {
        static void Main(string[] args)
        {
            double mes;
            System.Console.WriteLine("Digite um número correspondente ao mês desejado:");
            mes = double.Parse(Console.ReadLine());

            switch (mes){
                    case 1:
                    System.Console.WriteLine("Mês de Janeiro!");
                        break;
                    case 2:
                    System.Console.WriteLine("Mês de Fevereiro!");
                        break;
                    case 3:
                    System.Console.WriteLine("Mês de Março!");
                        break;
                    case 4:
                    System.Console.WriteLine("Mês de Abril!");
                        break;
                    case 5:
                    System.Console.WriteLine("Mês de Maio!");
                        break;
                    case 6:
                    System.Console.WriteLine("Mês de Junho!");
                        break;
                    case 7:
                    System.Console.WriteLine("Mês de Julho!");                       
                        break;
                    case 8:
                    System.Console.WriteLine("Mês de Agosto!");
                        break;
                    case 9:
                    System.Console.WriteLine("Mês de Setembro!");
                        break;
                    case 10:
                    System.Console.WriteLine("Mês de Outubro!");
                        break;
                    case 11:
                    System.Console.WriteLine("Mês de Novembro!");
                        break;
                    case 12:
                    System.Console.WriteLine("Mês de Dezembro!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Console.ReadLine();
                        break;
                }  
        }
    }
}
