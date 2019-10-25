using System;

namespace exer13
{
    class Program
    {
        static void Main(string[] args){
            double lad1;
            double lad2;
            double lad3;

            System.Console.WriteLine("Digite o primeiro lado do triângulo:");
            lad1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo lado do triângulo:");
            lad2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o terceiro lado do triângulo:");
            lad3 = double.Parse(Console.ReadLine());

            if(lad1 < (lad2 + lad3)){
                System.Console.WriteLine("Você possui um triângulo!");
            }else if(lad2 < (lad3 + lad1)){
                System.Console.WriteLine("Você possui um triângulo!");
            }else if (lad3 < (lad1 + lad2)){
                System.Console.WriteLine("Você possui um triângulo!");
            }else if (lad1 >= (lad2 + lad3)){
                System.Console.WriteLine("Você não tem um triângulo!");
            }else if (lad2 >= (lad3 + lad1)){
                System.Console.WriteLine("Você não tem um triângulo!");
            }else if (lad3 >= (lad1 + lad2)){
                System.Console.WriteLine("Você não tem um triângulo!");
            }
        }
    }
}
