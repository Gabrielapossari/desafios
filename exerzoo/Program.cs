using System;
using System.Collections.Generic;

namespace exerzoo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um animal");
            string opcao = Console.ReadLine();
            if(opcao == "Tucano"){
                System.Console.WriteLine("Tucano pertence a Casa na árvore");
            }else if (opcao == "Tubarão Martelo"){
                System.Console.WriteLine("Tubarão Martelo pertence ao Aquario");
            }else if (opcao == "Arara"){
                System.Console.WriteLine("Arara pertence ao Gaiola");
            }else if (opcao == "Leão"){
                System.Console.WriteLine("Leão pertence ao Pasto");
            }else if (opcao == "Pinguim"){
                System.Console.WriteLine("Pinguim pertence ao Piscina Gelada");
            }else if (opcao == "Golfinho"){
                System.Console.WriteLine("Golfinho pertence ao Piscina");
            }else if (opcao == "Tartaruga"){
                System.Console.WriteLine("Tartaruga pertence ao Piscina");
            }else if (opcao == "Chimpanzé"){
                System.Console.WriteLine("Chimpanzé pertence ao Caverna da pedra");
            }else if (opcao == "Orangotango"){
                System.Console.WriteLine("Orangotango pertence ao Caverna da pedra");

                
            }

        }
    }
}
