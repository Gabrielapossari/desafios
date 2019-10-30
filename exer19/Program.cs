using System;

namespace exer19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            System.Console.WriteLine("Digite um número:");
            n = int.Parse(Console.ReadLine());
            
            int [] vetor = new int[n];  /*Declarando um vetor e inicianizando*/
            for(int x = 0; x < n; x++ ){
                System.Console.Write($"{x}:");
                vetor[x] = int.Parse(Console.ReadLine());
            }
        }
    }
}
