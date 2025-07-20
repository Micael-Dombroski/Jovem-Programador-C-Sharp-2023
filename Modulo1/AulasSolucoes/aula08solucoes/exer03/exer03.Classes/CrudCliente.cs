using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer03.Classes
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
            ArquivandoDados();
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
                    break;
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
                    break;
                }
            }
            ArquivandoDados();
        }

        public void Excluir(Cliente cliente)
        {
            clientes.Remove(cliente.Cpf);
            ArquivandoDados();
        }
        public void ArquivandoDados()
        {
            if (File.Exists("cliente.txt"))
            {
                File.Delete("cliente.txt");
            }
            if (!File.Exists("cliente.txt"))
            {
                using (Stream saida = File.Open("cliente.txt", FileMode.Create))
                {
                    using (StreamWriter escritor = new StreamWriter(saida))
                    {
                        escritor.WriteLine(" Lista de Clientes");
                        escritor.WriteLine(" CPF | Nome | RG | Endereço");
                        foreach (KeyValuePair<string, Cliente> par in clientes)
                        {
                            Cliente item = par.Value;
                            string cpf = item.Cpf;
                            string rg = item.Rg;
                            escritor.Write($" {cpf[0]}{cpf[1]}{cpf[2]}.{cpf[3]}{cpf[4]}{cpf[5]}.{cpf[6]}{cpf[7]}{cpf[8]}-{cpf[9]}{cpf[10]} |");
                            escritor.Write($" {item.Nome} |");
                            escritor.Write($" {rg[0]}{rg[1]}.{rg[2]}{rg[3]}{rg[4]}.{rg[5]}{rg[6]}{rg[7]}-{rg[8]} |");
                            escritor.WriteLine($" {item.Endereco}");
                        }
                    }
                }
            } 
        }  
    }
}