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
                // Abrindo arquivo
                using(StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] dados = sr.ReadLine().Split(',');
                        string candidato = dados[0];
                        int votos = int.Parse(dados[1]);

                        if (dictionary.ContainsKey(candidato)) // Caso já tenha tal cantidato no dictionary.
                        {
                            dictionary[candidato] += votos; // Adiciona apenas os novos votos.
                        }
                        else
                        {
                            dictionary[candidato] = votos; // Adiciona os primeiros votos
                        }
                    }

                    foreach(var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("\nOcorreu um erro!\n" + e.Message);
            }
        }
    }
}