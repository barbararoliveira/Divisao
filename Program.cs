using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            double numerador, denominador; 
           
            Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(" ----- DIVISOR <3 ----- \n");
                            
            Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("Digite o numerador da divisão: ");
                            numerador = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o denominador da divisão: ");
                            denominador = Convert.ToDouble(Console.ReadLine());

            if (denominador == 0) 
            
            {
                Console.WriteLine("Não é possível dividir por zero.");
                Environment.Exit (-1);
            }

            double result = numerador / denominador ;

            Console.WriteLine ($"{numerador} dividido por {denominador} é {result}. ");
        }
    }
}
