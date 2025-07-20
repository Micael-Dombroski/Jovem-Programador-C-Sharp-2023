using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucaoTeste04.Classes
{
        public class CrudVeiculo:Veiculo
    {
        private Dictionary<String, Veiculo> veiculos;
        public CrudVeiculo (string placa, uint anoFabricacao, string modelo):base(placa, anoFabricacao, modelo)
        {
            veiculos = new Dictionary<String, Veiculo>();
        }
        public bool Cadastrar(Veiculo veiculo)
        {
            var data = DateTime.Now;
            uint anoAtual = Convert.ToUInt32(data.Year);
            bool jaCadastrada = false;
            foreach (KeyValuePair<String, Veiculo> par in veiculos)
            {
                if (par.Key == veiculo.Placa)
                {
                    jaCadastrada = true;
                    break;
                }
            }
            if (jaCadastrada == false)
            {
                if (veiculo.AnoFabricacao > anoAtual)
                {
                    Console.WriteLine("A data de fabricação do veículo não pode ser maior que a data atual.");
                    return false;
                }
                else
                {
                    veiculos.Add(veiculo.Placa, veiculo);
                    return true;
                } 
            }
            else
            {
                Console.WriteLine("Placa já Cadastrada");
                return false;
            }
        }
        public Veiculo ConsultarPlaca (string placa)
        {
            foreach (KeyValuePair<String, Veiculo> par in veiculos)
            {
                if (par.Key == placa)
                {
                    return par.Value;
                }
            }
            Console.WriteLine("Placa Não Encontrada");
            return null;
        }

        public Dictionary<String, Veiculo> ExibirVeiculos()
        {
            return veiculos;
        }

        public bool ExcluirVeiculo(string placa)
        {
            foreach (KeyValuePair<String, Veiculo> par in veiculos)
            {
                if (par.Key == placa)
                {
                    veiculos.Remove(placa);
                    return true;
                }
            }
            return false;
        }
    }
}