using System;

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
        }
    }
}