using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoTeste04.Classes
{
    public abstract class Veiculo
    {
        protected int Tipo;
        public string Placa;
        public uint AnoFabricacao;
        public string Modelo;
        public Veiculo (string placa, uint anoFabricacao, string modelo)
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
            return 2023 - (int)AnoFabricacao;
        }
    }
}