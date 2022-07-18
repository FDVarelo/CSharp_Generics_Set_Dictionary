using System;
using System.Collections.Generic;
using ConsoleApp4.Entities;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>(); // Cria o Produto 'a' com a entidade Product, porém com HashSet.
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>(); // Cria o Point 'b' com a entidade Point, porém com HashSet.
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0); // Cria o Produto "prod" com a entidade Product.
            Console.WriteLine(a.Contains(prod)); // Verifica se o Produto 'a' tem algum produto igual a "prod".

            Point point = new Point(5, 10); // Cria o Point "point" com a entidade Point.
            Console.WriteLine(b.Contains(point)); // Verifica se o Point 'b' tem algum Point igual a "point".

            // Deve-se retornar true caso verdadeiro, e false caso seja falso.
            // Vale ressaltar caso seja testado: - Console.WriteLine(a.Contains(point)); - também dara erro, pois 'a' é uma entidade Product, e point é uma entidade Point.
        }
    }
}