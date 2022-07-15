using System;
using System.Collections.Generic;

namespace ConsoleApp1.Services
{
    class Calcular
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("A lista não pode estar vazia!");
            }

            T max = list[0]; // max começa na posição 0.
            for (int i = 1; i < list.Count; i++) // Rodar o resto da lista para verificar quem é o max
            {
                if (list[i].CompareTo(max) > 0) // Caso o valor encontrado na list[i] for maior que o meu max
                {
                    max = list[i]; // max passa a ser list[i]
                }
            }
            return max;
        }

    }
}
