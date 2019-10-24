using System;

namespace nume
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;


            Console.WriteLine("Digite um primeiro número:");
            num1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite um segundo número:");
            num2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"O primeiro número agora é  {num2}");
            
            System.Console.WriteLine($"O segundo número agora é  {num1}");
        }
    }
}
