using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SolucaoBanco.Classes;

namespace SolucaoBanco.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cliente cliente = new Cliente
            {
                Cpf = "111.111.111-58",
                Rg = "1.111.111-1",
                Nome = "Goku",
                Endereco = "Amazonas"
            };*/

            ClienteDAO clienteDAO = new ClienteDAO();
            //clienteDAO.Adicionar(cliente);
            /*Cliente cliente1 = clienteDAO.ConsultarPorCpf("111.111.111-11");
            Console.WriteLine(cliente1.ToString());*/
            Cliente cliente = clienteDAO.ConsultarPorCpf("111.111.111-11");
            cliente.Rg = "0.123.456-7";
            cliente.Nome = "Maria";
            cliente.Endereco = "EUA";
            clienteDAO.Editar(cliente);
            clienteDAO.Excluir("000.000.000-00");
            foreach (var item in clienteDAO.ConsultarTodos())
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
