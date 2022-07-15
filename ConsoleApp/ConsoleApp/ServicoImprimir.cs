namespace ConsoleApp
{
    class ServicoImprimir<T>
    {
        private T[] _valores = new T[0];
        private int _contador = 0;

        public void AddValor(T valor)
        {
            if(_contador == 10)
            {
                throw new InvalidOperationException("ServicoImprimir já atingiu o máximo de valores!");
            }
            _valores[_contador] = valor;
            _contador++;
        }

        public T Primeiro()
        {
            if(_contador == 0)
            {
                throw new InvalidOperationException("ServicoImprimir está vazio!");
            }
            return _valores[0];
        }

        public void Printar()
        {
            Console.Write("[");
            for(int i = 0; i < _contador - 1; i++)
            {
                Console.Write(_valores[i] + ", ");
            }
            if(_contador > 0)
            {
                Console.Write(_valores[_contador - 1]);
            }
            Console.Write("]");
        }
    }
}
