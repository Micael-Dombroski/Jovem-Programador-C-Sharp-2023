using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula08
{
    public class CrudConta
    {
        private Conta[] contas = new Conta[0];
        public void Adicionar(Conta conta)
        {
            Conta [] contasTemporaria = new Conta[contas.Length + 1];
            for (int i = 0; i < contas.Length; i++)
            {
                contasTemporaria[i] = contas[i];
            }
            contasTemporaria[contas.Length] = conta;
            contas = contasTemporaria;
        }
        public Conta Consultar(int agencia, int numero)
        {
            Conta conta = null;
            for (int i = 0; i < contas.Length; i++)
            {
                if (contas[i].Agencia == agencia && contas[i].Numero == numero)
                {
                    conta = contas[i];
                    break;
                }
            }
            return conta;
        }
        public Conta[] ListarContas()
        {
            return contas;
        }
        public void Editar (Conta conta)
        {
            for (int i = 0; i < contas.Length; i++)
            {
                if (contas[i].Agencia == conta.Agencia && contas[i].Numero == conta.Numero)
                {
                    contas[i] = conta;
                }
            }
        }
        public void Excluir (int agencia, int numero)
        {
            Conta conta = Consultar(agencia, numero);
            if (conta == null)
            {
                return;
            }
            else
            {
                Conta [] contasTemporaria = new Conta[contas.Length - 1];
                if (contasTemporaria.Length < 0)
                {
                    Console.WriteLine("Nenhuma conta foi cadastrada ainda");
                }
                else
                {
                    bool pular1 = false;
                    for (int i = 0; i < contasTemporaria.Length; i++)
                    {
                        if (contas[i].Numero == numero)
                        {
                            pular1 = true;
                        }
                        if (pular1 == true)
                        {
                            contasTemporaria[i] = contas[i+1];
                        }
                        else
                        {
                            contasTemporaria[i] = contas[i];
                        }
                    }
                    contas = contasTemporaria;
                }
            }   
        }
    }
}