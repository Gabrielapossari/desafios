using System;

namespace exer14
{
    class Program
    {
        static void Main(string[] args)
        {
            string verbo;
            string sufixo;
            string verb;
            Console.WriteLine("Escreve um verbo:");
            verbo = (Console.ReadLine());

            sufixo = verbo.Substring(verbo.Length-2,2);
            verb = verbo.Substring(verbo.Length-1,1);

            verbo=sufixo.Replace((sufixo), "ar");

            if (verb == "r"){
                System.Console.WriteLine("Você tem um verbo!");
            }else{
                System.Console.WriteLine("Você não tem um verbo!");
            }
        }
    }
}

