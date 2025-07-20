using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01.Classes
{
    public class CrudCliente:Cliente
    {
        private List<Cliente> clientes;
        private static int Index = 0;
        public CrudCliente(string nome, string cpf, string rg, string endereco):base(nome, cpf, rg, endereco)
        {
            clientes = new List<Cliente>();
            Nome=nome;
            Cpf = cpf;
            Rg = rg;
            Endereco = endereco;

        }

        public void Cadastrar(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public List<Cliente> ConsultarTodos()
        {
            return clientes;
        }

        public int  MostrarTamanho()
        {
            Index = 0;
            return clientes.Count;
        }

        public Cliente PassarCadaItem()
        {
            return clientes[Index];
            Index++;
        }

        public Cliente ConsultarCPF(string cpf)
        {
            foreach (var item in clientes)
            {
                if (item.Cpf == cpf)
                {
                    return item;
                }
            }
            return null;
        }

        public void Editar(Cliente cliente)
        {
            clientes.Remove(cliente);
            clientes.Add(cliente);
        }

        public void Excluir(Cliente cliente)
        {
            clientes.Remove(cliente);
        }
    }
}