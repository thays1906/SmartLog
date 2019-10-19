namespace SmartLog.Model.Entidade.pessoa
{
    class Cliente : Pessoa
    {
        public Cliente(string nome, string telefone, string email, Endereco endereco) 
            : base(nome, telefone, email, endereco)
        {
        }
    }
}
