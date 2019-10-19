namespace SmartLog.Model.Entidade.pessoa
{
    class Gerente : Funcionario
    {
        public Gerente(string nome, string telefone, string email, double matricula, Endereco endereco)
            : base(nome, telefone, email, matricula, endereco)
        {

        }
    }
}
