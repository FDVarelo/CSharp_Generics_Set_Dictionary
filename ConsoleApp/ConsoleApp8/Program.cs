using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Caso queira que o usuário decida o diretorio:
            //Console.Write("Enter file full path: ");
            //string path = Console.ReadLine();

            // Commitar a linha abaixo caso queira que o usuário decida o diretorio.
            string path = @"C:\temp\CSharp_Generics_Set_Dictionary\ConsoleApp\ConsoleApp8\texts\file.csv";

            try
            {

            }
            catch (IOException e)
            {
                Console.WriteLine("\nOcorreu um erro!\n" + e.Message);
            }
        }
    }
}