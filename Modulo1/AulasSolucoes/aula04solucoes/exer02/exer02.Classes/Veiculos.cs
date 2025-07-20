using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02.Classes
{
    public abstract class Veiculos
    {
        protected int Tipo;
        public string Placa;
        public int AnoFabricacao;
        public string Modelo;
        public Veiculos (string placa, int anoFabricacao, string modelo)
        {
            Placa = placa;
            AnoFabricacao = anoFabricacao;
            Modelo = modelo;
        }
        public virtual void TipoVeiculo()
        {

        }
        public int MostrarTipo()
        {
            return Tipo;
        }
        public int IdadeDoVeiculo()
        {
            return 2023 - AnoFabricacao;
        }
    }
}