using System;
using ConsoleApp2.Entities;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iniciando testes com Equals e GetHashCode
            string a = "Alex";
            string b = "Bia";

            Console.WriteLine("Equals: " + a.Equals(b)); // Mais demorado, porém 100% de resposta.
            Console.WriteLine("GetHashCode (a): " + a.GetHashCode()); // Mais rápido, porém resposta positiva não é 100%.
            Console.WriteLine("GetHashCode (b): " + b.GetHashCode());

            // GetHashCode, por que motivo ã resposta não é 100% positiva:
            // Se o código de dois objetos for diferente, então os dois objetos são diferentes, porém,
            // se o código de dois objetos for igual, muito provavelmente os objetos são iguais(pode haver colisão) ←

            Console.WriteLine("\nUtilizando Classe Cliente com Equal e GetHashCode:\n");

            Cliente c = new Cliente { Nome = "Camila", Email = "camila@email.com" };
            Cliente d = new Cliente { Nome = "Daniel", Email = "daniel@email.com" };

            // O Equals e o GetHashCode so é possível fazer com classe por conta do override na classe Cliente.
            Console.WriteLine("Equals Cliente (c) e (d): " + a.Equals(b));
            Console.WriteLine("GetHashCode (c): " + c.GetHashCode());
            Console.WriteLine("GetHashCode (d): " + d.GetHashCode());

            // Outros testes.
            int num1 = 1;
            char numUm = '1';
            string numUms = "1";

            Console.WriteLine("\nTeste entre tipos diferentes int 1 / char '1' / string \"1\":\n\nEquals:");
            Console.WriteLine("int e char: " + num1.Equals(numUm));
            Console.WriteLine("int e string: " + num1.Equals(numUms));
            Console.WriteLine("char e string: " + numUm.Equals(numUms));
            Console.WriteLine("\nGetHashCode:");
            Console.WriteLine("int: " + num1.GetHashCode());
            Console.WriteLine("char: " + numUm.GetHashCode());
            Console.WriteLine("string: " + numUms.GetHashCode());
        }
    }
}