namespace ConsoleApp2.Entities
{
    class Cliente
    {
        // Utilização de Equal e GetHashCode em classes.
        public string Nome { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)
        {
            if(!(obj is Cliente)) // Verifica se não é um cliente.
            {
                return false;
            }
            Cliente cliente = obj as Cliente;
            return Email.Equals(cliente.Email); // Compara o Email com o outro Email.
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode(); // Pega o HashCode do email.
        }
    }
}
