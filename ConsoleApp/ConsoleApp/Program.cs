using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos valores serão passados? ");
            int valores = int.Parse(Console.ReadLine());

            for(int i = 0; i < valores; i++)
            {
                Console.Write("Valor " + (i+1) + ": ");
                int x = int.Parse(Console.ReadLine());
            }
        }
    }
}