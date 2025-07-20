using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoTeste04.Classes
{
    public class Caminhao:Veiculo, IPedagio
    {
        public double PesoTotal;
        public double ValorCarga;
        public Caminhao (string placa, uint anoFabricacao, string modelo, double pesoTotal, double valorCarga):base (placa, anoFabricacao, modelo)
        {
            Placa = placa;
            AnoFabricacao = anoFabricacao;
            Modelo = modelo;
            PesoTotal = pesoTotal;
            ValorCarga = valorCarga;
        }
        public double Pedagio()
        {
            return 40.00;
        }
        public override void TipoVeiculo()
        {
            Tipo = 3;
        }
    }
}