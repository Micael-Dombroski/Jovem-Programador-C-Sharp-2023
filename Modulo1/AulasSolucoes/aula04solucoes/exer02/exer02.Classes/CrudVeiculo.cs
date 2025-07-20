using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02.Classes
{
    public class CrudVeiculo:Veiculos
    {
        private Dictionary<String, Veiculos> veiculos;
        public CrudVeiculo (string placa, int anoFabricacao, string modelo):base(placa, anoFabricacao, modelo)
        {
            veiculos = new Dictionary<String, Veiculos>();
        }
        public void Cadastrar(Veiculos veiculo)
        {
            veiculos.Add(veiculo.Placa, veiculo);
        }
        public Veiculos ConsultarPlaca (string placa)
        {
            foreach (KeyValuePair<String, Veiculos> par in veiculos)
            {
                if (par.Key == placa)
                {
                    return par.Value;
                }
            }
            return null;
        }
    }
}