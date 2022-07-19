using System;
using ConsoleApp5.Entities;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>(); // Cria uma entidade LogRecord com HashSet.

            //Console.Write("Enter file full path: "); // Descomentar caso queir aque o usuário defina o caminho a ser escolhido.
            //string path = Console.ReadLine();

            string path = @"C:\temp\CSharp_Generics_Set_Dictionary\ConsoleApp\ConsoleApp5\texts\file.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path)) // Abrindo o arquivo.
                {
                    while (!sr.EndOfStream) // Enquanto não acabar o arquivo.
                    {
                        string[] line = sr.ReadLine().Split(' '); // Dividir o arquivo em 'name' e 'instant'.

                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        set.Add(new LogRecord { Username = name, Instant = instant }); // Adiciona o novo LogRecord.
                    }
                    Console.WriteLine("Total users: " + set.Count); // Printa na tela a quantidade de usuários cadastrados em set.
                }
            }
            catch (IOException e) // Caso não encontre o arquivo, ou de qualquer outro tipo de erro.
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
