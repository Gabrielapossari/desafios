﻿using System;

namespace AREAdp
{
    class Program
    {
        static void Main(string[] args)
        {
            double Lado;
            double altura;
            double diag;

            System.Console.WriteLine("Qual é a base do retangulo?");
            Lado = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Qual é a altura do retangulo?");
            altura = double.Parse(Console.ReadLine());

            System.Console.WriteLine("O perímetro do retangulo:");
            System.Console.WriteLine(2*Lado + 2*altura);
            System.Console.WriteLine("A área do retangulo:");
            System.Console.WriteLine(Lado*altura);
            System.Console.WriteLine("A diagonal do retangulo:");
            diag = Math.Sqrt((Lado*Lado + altura*altura));
            System.Console.WriteLine(diag);
            diag = double.Parse(Console.ReadLine());
        }
    }
}
