using System;

namespace exer18
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; 
            Console.WriteLine("Defina um número:");
            num = int.Parse(Console.ReadLine());

        for (int  i=0;  i<=num; i++)
        {
            if (i % 2 != 0){
                Console.WriteLine(i);
            }else{
            }
        }
            
        }
    }
}
