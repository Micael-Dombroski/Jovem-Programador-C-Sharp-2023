using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02.Classes
{
    public class Moto:Veiculos, IPedagio
    {
        public int QtCilindradas;
        public Moto (string placa, int anoFabricacao, string modelo, int qtCilidradas):base (placa, anoFabricacao, modelo)
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