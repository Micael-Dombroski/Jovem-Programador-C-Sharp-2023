using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02.Classes
{
    public class Carro:Veiculos, IPedagio
    {
        public int QtPassageiros;
        public Carro (string placa, int anoFabricacao, string modelo, int qtPassageiros):base (placa,anoFabricacao,modelo)
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