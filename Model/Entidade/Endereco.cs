namespace SmartLog.Model.Entidade
{
    class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF{ get; set; }

        public Endereco(string logradouro)
        {
            Logradouro = logradouro;
        }

        public override string ToString()
        {
            return "Logradouro: "
                + Logradouro.ToString()
                + ", Nº: "
                + Numero.ToString()
                + "\n" + Bairro.ToString()
                + " - " + Cidade.ToString()
                + " - " + UF.ToString();
        }
    }
}
