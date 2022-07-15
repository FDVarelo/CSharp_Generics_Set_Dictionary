using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de produtos: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                string[] vet = Console.ReadLine().Split(',');
                double preco = double.Parse(vet[1], CultureInfo.InvariantCulture);
            }
        }
    }
}