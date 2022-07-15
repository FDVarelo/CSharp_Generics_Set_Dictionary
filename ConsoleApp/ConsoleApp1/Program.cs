using System;
using System.Globalization;
using ConsoleApp1.Entities;
using ConsoleApp1.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            Console.Write("Quantidade de produtos: ");
            int qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("\nProduto deve ser passado da seguinte maneira: Smartphone X,1050.00");
            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Produto " + i + ": ");
                string[] vet = Console.ReadLine().Split(',');
                double preco = double.Parse(vet[1], CultureInfo.InvariantCulture);

                lista.Add(new Produto(vet[0], preco));
            }

            Calcular calcular = new Calcular();
            Produto p = calcular.Max(lista);

            Console.WriteLine("\nProduto mais caro:");
            Console.WriteLine(p);
        }
    }
}