using System;

namespace exer14
{
    class Program
    {
        static void Main(string[] args)
        {
            string verbo;
            string sufixo;

            Console.WriteLine("Escreve um verbo:");
            verbo = (Console.ReadLine());

            sufixo = verbo.Substring(verbo.Length-2,2);
            
            if (sufixo.EndsWith("ar")) {
                System.Console.WriteLine("Você tem um verbo na primeira conjugação!");
            }else if (sufixo.EndsWith("er")){
                System.Console.WriteLine("Você tem um verbo na segunda conjugação!");
            }else if (sufixo.EndsWith("ir")){
                System.Console.WriteLine("Você tem um verbo na terceira conjugação!");
            }else {
                    System.Console.WriteLine("O verbo não está no infinitivo.");
            }
        }
    }
}

