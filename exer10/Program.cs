using System;

namespace exer10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            System.Console.WriteLine("Digite um número:");
            num1 = int.Parse(Console.ReadLine());

            if (num1%3 == 0){
                System.Console.WriteLine("Esse número é multiplo de 3!");
            }else {
                System.Console.WriteLine("Esse número não é multiplo de 3!");
            }
        }
    }
}
