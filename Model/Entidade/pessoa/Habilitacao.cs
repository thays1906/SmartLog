using System;

namespace SmartLog.Model.Entidade.pessoa
{
    class Habilitacao
    {
        public DateTime Vencimento { get; set; }
        public string Categoria { get; set; }
        public int NumRegistro { get; set; }

        public Habilitacao(int numRegistro, string categoria)
        {
            NumRegistro = numRegistro;
            Categoria = categoria;
        }
    }
}
