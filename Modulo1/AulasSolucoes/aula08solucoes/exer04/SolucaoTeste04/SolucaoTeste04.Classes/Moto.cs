using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoTeste04.Classes
{
    public class Moto:Veiculo, IPedagio
    {
        public uint QtCilindradas;
        public Moto (string placa, uint anoFabricacao, string modelo, uint qtCilidradas):base (placa, anoFabricacao, modelo)
        {
            Placa = placa;
            AnoFabricacao = anoFabricacao;
            Modelo = modelo;
            QtCilindradas = qtCilidradas;
        }
        public double Pedagio ()
        {
            return 10.00;
        }
        public override void TipoVeiculo()
        {
            Tipo = 2;
        }
    }
}