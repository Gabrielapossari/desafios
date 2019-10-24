using System;

namespace exer9
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;
            int opcao;
            peso = 0;

            System.Console.WriteLine("Qual é o peso do planeta?");
            peso = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Escola um planeta:");
            System.Console.WriteLine("1  - Mercúrio ");
            System.Console.WriteLine("2  - Vênus");
            System.Console.WriteLine("3  - Marte");
            System.Console.WriteLine("4  - Júpiter ");
            System.Console.WriteLine("5  - Saturno");
            System.Console.WriteLine("6  - Urano"); 
            opcao = int.Parse(Console.ReadLine());


            switch (opcao){
                    case 1:
                    System.Console.WriteLine((peso/10)*0.37);
                    Console.ReadLine();
                        break;
                    case 2:
                    System.Console.WriteLine((peso/10)*0.88);
                    Console.ReadLine();
                        break;
                    case 3:
                    System.Console.WriteLine((peso/10)*0.38);
                    Console.ReadLine();
                        break;
                    case 4:
                    System.Console.WriteLine((peso/10)*2.64);
                    Console.ReadLine();
                        break;
                    case 5:
                    System.Console.WriteLine((peso/10)*1.15);
                    Console.ReadLine();
                        break;
                    case 6:
                    System.Console.WriteLine((peso/10)*1.17);
                    Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Console.ReadLine();
                        break;
                }  
        }
    }
}
