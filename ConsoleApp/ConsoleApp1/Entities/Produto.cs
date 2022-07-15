using System;
using System.Globalization;

namespace ConsoleApp1.Entities
{
    class Produto : IComparable
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Produto))
            {
                throw new ArgumentException("Erro na comparação: argumento não é um Produto!");
            }
            Produto produto = obj as Produto;
            return Preco.CompareTo(produto.Preco);
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
