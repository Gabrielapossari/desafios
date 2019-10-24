using System;

namespace viajem
{
    class Program
    {
        static void Main(string[] args)
        {
            double vel;
            double temp;
            double dist;
            double quant;
            Console.WriteLine("Qual é a velocidade média gasta na viajem em Km/h?");
            vel = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual é o tempo total gasto na viajem em hora?");
            temp = double.Parse(Console.ReadLine());
            System.Console.WriteLine("A distância total:");
            System.Console.WriteLine(vel / temp);
            dist = vel / temp;
            System.Console.WriteLine("A quantidade de litros utilizados na viagem:");
            System.Console.WriteLine(dist*12);
            Console.ReadLine();
            quant = double.Parse(Console.ReadLine());
            Console.ReadLine();
            
            
        }
    }
}
