using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer04.Classes
{
    public class Carro:Veiculo, IPedagio
    {
        public uint QtPassageiros;
        public Carro (string placa, uint anoFabricacao, string modelo, uint qtPassageiros):base (placa,anoFabricacao,modelo)
        {
            Placa = placa;
            AnoFabricacao = anoFabricacao;
            Modelo = modelo;
            QtPassageiros = qtPassageiros;
        }
        public double Pedagio ()
        {
            return 20.00;
        }
        public override void TipoVeiculo()
        {
            Tipo = 1;
        }
    }
}