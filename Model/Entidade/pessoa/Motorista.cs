namespace SmartLog.Model.Entidade.pessoa
{
    class Motorista : Funcionario
    {
        Habilitacao Habilitacao { get; set; }
        public Motorista(string nome, string telefone, string email, double matricula, Endereco endereco, Habilitacao habilitacao)
            : base(nome, telefone, email, matricula, endereco)
        {
            Habilitacao = habilitacao;
        }
    }
}
