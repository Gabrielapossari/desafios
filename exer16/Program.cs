using System;

namespace exer16
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double imc=0;


            Console.WriteLine("Qual é o seu peso?");
            peso = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual é a sua altura?");
            altura = double.Parse(Console.ReadLine());

            imc = (peso/(altura*altura));
            System.Console.WriteLine(imc);
            

            if (imc<20) {
                System.Console.WriteLine("Você está abaixo do peso!");
            }else if (imc>20 && imc<25){
                System.Console.WriteLine("Você está o peso normal!");
            }else if (imc>25 && imc<30){
                System.Console.WriteLine("Você está com excesso de peso!");
            }else if (imc>30 && imc<35){
                System.Console.WriteLine("Você está obeso!");
            }else if(imc>35){
                System.Console.WriteLine("Você está com obesidade mórbida!");
            }  
        }
    }
}
