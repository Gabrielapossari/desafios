using System;

namespace exer20
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor = new int[10]; 
            for(int x = 0; x < 10; x++ ){
                Random randNum = new Random();
                System.Console.Write($"{x}:");
                vetor[x] = int.Parse(Console.ReadLine());
            }
        }
    }
}
