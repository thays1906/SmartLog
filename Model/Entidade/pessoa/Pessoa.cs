namespace SmartLog.Model.Entidade.pessoa
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }

        protected Pessoa(string nome, string telefone, string email, Endereco endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
        }
    }
}
