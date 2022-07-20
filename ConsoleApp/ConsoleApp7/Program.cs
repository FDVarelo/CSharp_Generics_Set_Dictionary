using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            // Demonstração:
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "fred";
            cookies["email"] = "fred@gmail.com";
            cookies["phone"] = "11223344";
            cookies["phone"] = "55667788"; // Renomeia o phone.

            Console.WriteLine(cookies["email"]);
            cookies.Remove("email"); // Retira o campo de email.
            Console.WriteLine("Email has been removed!\n");
            Console.WriteLine("Phone number: " + cookies["phone"]);

            Console.WriteLine("Finding Email.");
            if (cookies.ContainsKey("email")) // Verifica se tem algum campo chamado email.
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is not 'email' key.");
            }

            Console.WriteLine("\nALL COOKIES:");
            Console.WriteLine("Size: " + cookies.Count); // Tamanho de cookies.

            foreach (KeyValuePair<string, string> item in cookies) // Percorrer todos os itens em cookies.
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}