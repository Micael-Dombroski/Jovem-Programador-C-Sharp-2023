using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02
{
    public class Cliente
    {
        private static int ID;
        private int IdCliente;
        public string Nome;
        public int Idade;
        public Endereco Endereco;
        public Cliente (string nome, int idade, Endereco endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }
        public void AumentarID()
        {
            ID++;
        }
        public void AtribuirID()
        {
            IdCliente=ID;
        }
    }
}