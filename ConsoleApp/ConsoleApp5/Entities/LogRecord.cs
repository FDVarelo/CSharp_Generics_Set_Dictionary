using System;

namespace ConsoleApp5.Entities
{
    class LogRecord
    {

        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode(); // Retorna o nome/username, que ele ira buscar.
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRecord)) // Se não por um LogRecord.
            {
                return false;
            }

            // Caso seja um LogRecord
            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username); // Verifica se tem algum username cadastrado com aquele username.
        }
    }
}