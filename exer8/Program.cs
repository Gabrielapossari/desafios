using System;

namespace exer8
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            Console.WriteLine("Qual é a altura do triângulo?");
            altura = double.Parse(Console.ReadLine());
            
            for(int i = 0;i<altura;i++){
                System.Console.WriteLine("*");
            }
            
        }
    }
}
