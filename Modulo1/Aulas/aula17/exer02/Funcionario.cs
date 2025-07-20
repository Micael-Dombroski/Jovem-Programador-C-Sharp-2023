using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02
{
    public abstract class Funcionario
    {
        public string Cpf{get;set;}
        public string Cnpj{get;set;}
        public int Tipo;
        public string Nome{get;set;}
        public const double salarioMinimo = 1000.00;
        public double Salario;
        public string Funcao{get;set;}
        public Endereco Endereco;
        public Funcionario(string nome)
        {
            Nome=nome;
        }
        public virtual void SalarioFuncionario()
        {
            Salario = salarioMinimo;
        }
        public abstract void FuncaoFuncionario();
        /*public struct Endereco
        {
            public string Rua;
            public string Numero;
            public string Bairro;
            public string Cidade;
            public string Estado;
            public Endereco (string rua, string numero, string bairro, string cidade, string estado)
            {
                Rua = rua;
                Numero = numero;
                Bairro = bairro;
                Cidade = cidade;
                Estado = estado;
            }
        }*/
    }
}