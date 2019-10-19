namespace SmartLog.Model.Entidade.pessoa
{
    class Atendente : Funcionario
    {
        public Atendente(string nome, string telefone, string email, double matricula, Endereco endereco)
            : base(nome, telefone, email, matricula, endereco)
        {

        }
    }
}
