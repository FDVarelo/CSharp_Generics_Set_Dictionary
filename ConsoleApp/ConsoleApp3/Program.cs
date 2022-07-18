using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------\niNICIANDO SORTEDSET:\n");
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
            Console.Write("A: ");
            printCollection(a);
            Console.Write("B: ");
            printCollection(b);

            Console.Write("\nUnião de A com B: ");
            // União
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); // Junta 'c' com 'b'.
            printCollection(c); // Printa a junção.

            Console.Write("Interseção de A com B: ");
            // Interseção
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); // 'd' interseção com 'b'.
            printCollection(d);

            Console.Write("Diferença de A para B (tem em A mas não tem em B): ");
            // Diferença
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b); // Diferença de 'e' para 'b'.
            printCollection(e);

            Console.Write("Diferença de B para A (tem em B mas não tem em A): ");
            // Diferença
            SortedSet<int> f = new SortedSet<int>(b);
            f.ExceptWith(a); // Diferença de 'e' para 'b'.
            printCollection(f);


            Console.WriteLine("\n---------------------------------------------\nINICIANDO HASHSET:\n");
            HashSet<string> set = new HashSet<string>();
            // Adicionando no HashSet
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            // Verificando no HashSet se contém a string "Notebook"
            Console.WriteLine(set.Contains("Notebook"));
            foreach (String p in set)
            {
                Console.WriteLine(p); // Printar o HashSet
            }
            
        }
        static void printCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

    }
}