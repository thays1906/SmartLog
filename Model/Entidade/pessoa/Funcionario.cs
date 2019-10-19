namespace SmartLog.Model.Entidade.pessoa
{
    class Funcionario : Pessoa
    {
        public double Matricula { get; set; }
        protected Funcionario(string nome, string telefone, string email, double matricula, Endereco endereco) 
            : base(nome, telefone, email, endereco)
        {
            Matricula = matricula;
        }
    }
}
