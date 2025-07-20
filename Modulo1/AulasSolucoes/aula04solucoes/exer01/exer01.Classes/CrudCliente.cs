using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01.Classes
{
    public class CrudCliente:Cliente
    {
        private Dictionary<String, Cliente> clientes;
        public CrudCliente(string nome, string cpf, string rg, string endereco):base(nome, cpf, rg, endereco)
        {
            clientes = new Dictionary<String, Cliente>();
            Nome=nome;
            Cpf = cpf;
            Rg = rg;
            Endereco = endereco;

        }

        public void Cadastrar(Cliente cliente)
        {
            clientes.Add(cliente.Cpf, cliente);
        }

        public Dictionary<String, Cliente> ConsultarTodos()
        {
            return clientes;
        }

        public Dictionary<string,Cliente> PassarCadaItem()
        {
            return clientes;
        }

        public Cliente ConsultarCPF(string cpf)
        {
            foreach (KeyValuePair<string, Cliente> par in clientes)
            {
                if (par.Key == cpf)
                {
                    return par.Value;
                }
            }
            return null;
        }

        public void Editar(Cliente cliente)
        {
            foreach (KeyValuePair<string, Cliente> par in clientes)
            {
                if (par.Key == cliente.Cpf)
                {
                    clientes.Remove(par.Key);
                    clientes.Add(cliente.Cpf, cliente);
                }
            }
        }

        public void Excluir(Cliente cliente)
        {
            clientes.Remove(cliente.Cpf, cliente);
        }
    }
}