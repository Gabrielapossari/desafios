using System;

namespace TEMPdp
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp;
            Console.WriteLine("Digite a temperatura em graus Celsius:");
            temp = double.Parse(Console.ReadLine());
            System.Console.WriteLine("A temperatura em Fahrenheit:");
            System.Console.WriteLine(((temp*9) + 160) /5);
            Console.ReadLine();
        }
    }
}
