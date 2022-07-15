using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicoImprimir<int> printarServico = new ServicoImprimir<int>();

            Console.Write("Quantos valores serão passados? ");
            int valores = int.Parse(Console.ReadLine());
            while(valores > 10 || valores < 1)
            {
                Console.WriteLine("\nQuantidade de valores não suportada! [1 até 10] apenas.\n");
                Console.Write("Quantos valores serão passados? ");
                valores = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < valores; i++)
            {
                Console.Write("Valor " + (i+1) + ": ");
                int x = int.Parse(Console.ReadLine());

                printarServico.AddValor(x);
            }

            printarServico.Printar();
            Console.WriteLine("\nPrimeiro valor: " + printarServico.Primeiro());
        }
    }
}