using System;

namespace ConsolaApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação dos três HashSet dos cursos.
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("How many students in course A? > ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                A.Add(student);
            }

            Console.Write("How many students in course B? > ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                B.Add(student);
            }

            Console.Write("How many students in course C? > ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                C.Add(student);
            }

            // Criação de um HashSet final unindo todos os outros três, sem repetir os mesmos valores.
            HashSet<int> final = new HashSet<int>(A);
            final.UnionWith(B);
            final.UnionWith(C);

            Console.WriteLine("Total students: " + final.Count); // Printar a quantidade de itens em final.

        }
    }
}