using System;

namespace exer12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("Digite o primeiro número:");
            num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o segundo número:");
            num2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o terceiro número:");
            num3 = int.Parse(Console.ReadLine());

            if (num1 < num2 && num1 < num3 && num2 < num3){
                System.Console.WriteLine($"O primeiro número agora é  {num1}");
                System.Console.WriteLine($"O segundo número agora é  {num2}");
                System.Console.WriteLine($"O terceiro número agora é  {num3}");
            }else if (num1 > num2 && num1 > num3 && num3 < num2 ){
                System.Console.WriteLine($"O primeiro número agora é  {num3}");
                System.Console.WriteLine($"O segundo número agora é  {num2}");
                System.Console.WriteLine($"O terceiro número agora é  {num1}");              
            }else if (num1 < num2 && num1 > num3 && num3 < num2 ){
                System.Console.WriteLine($"O primeiro número agora é  {num2}");
                System.Console.WriteLine($"O segundo número agora é  {num1}");
                System.Console.WriteLine($"O terceiro número agora é  {num3}"); 
            }else if (num1 > num2 && num1 < num3 && num3 > num2 ){
                System.Console.WriteLine($"O primeiro número agora é  {num3}");
                System.Console.WriteLine($"O segundo número agora é  {num1}");
                System.Console.WriteLine($"O terceiro número agora é  {num2}"); 
            }else if (num1 > num2 && num1 < num3 && num3 > num2 ){
                System.Console.WriteLine($"O primeiro número agora é  {num3}");
                System.Console.WriteLine($"O segundo número agora é  {num1}");
                System.Console.WriteLine($"O terceiro número agora é  {num2}"); 
            }else if (num1 > num2 && num1 < num3 && num3 > num2 ){
                System.Console.WriteLine($"O primeiro número agora é  {num3}");
                System.Console.WriteLine($"O segundo número agora é  {num1}");
                System.Console.WriteLine($"O terceiro número agora é  {num2}");     
            }else if (num1 < num2 && num1 < num3 && num3 < num2 ){
                System.Console.WriteLine($"O primeiro número agora é  {num1}");
                System.Console.WriteLine($"O segundo número agora é  {num3}");
                System.Console.WriteLine($"O terceiro número agora é  {num2}");   
        }else if (num1 > num2 && num1 > num3 && num3 > num2 ){
                System.Console.WriteLine($"O primeiro número agora é  {num2}");
                System.Console.WriteLine($"O segundo número agora é  {num3}");
                System.Console.WriteLine($"O terceiro número agora é  {num1}"); 
            }
        }
    }
}