using System;

namespace nume
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double numero;


            Console.WriteLine("Digite um primeiro número:");
            num1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite um segundo número:");
            num2 = double.Parse(Console.ReadLine());

            numero = num1;
            num1 = num2;
            num2 = numero;

            System.Console.WriteLine($"O primeiro número é {num1}");
            System.Console.WriteLine($"O segundo número é {num2}");

        }
    }
}
