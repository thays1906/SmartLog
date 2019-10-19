using System;

namespace SmartLog.Model.Entidade.veiculo
{
    class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao{ get; set; }
        public DateTime DataUltimaRevisão { get; set; }
        public int Quilometragem { get; set; }
        public StatusVeiculo Status { get; set; }

        public Veiculo(string marca, string modelo, int anoFabricacao, DateTime dataUltimaRevisão, int quilometragem)
        {
            Marca = marca;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
            DataUltimaRevisão = dataUltimaRevisão;
            Quilometragem = quilometragem;
            Status = 0;
        }
    }
}
