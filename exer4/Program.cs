using System;

namespace Par
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do{
                Console.Write("Diga um número: ");
                num = int.Parse(Console.ReadLine());

                if (num != 0){
                    if (num % 2 == 0){
                        Console.WriteLine("O número é par");
                    } else {
                        Console.WriteLine("O número é impar");
                    }
                }
            } while(num != 0);
        }
    }
}