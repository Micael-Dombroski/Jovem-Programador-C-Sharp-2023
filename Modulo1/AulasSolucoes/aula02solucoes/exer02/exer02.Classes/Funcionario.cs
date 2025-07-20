using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02.Classes
{
    public abstract class Funcionario
    {
        public string Cpf = "";
        public string Cnpj = "";
        public int Tipo;
        public string Nome{get;set;}
        public const double salarioMinimo = 1000.00;
        public double Salario;
        public string Funcao{get;set;}
        public Endereco Endereco;
        private static int ID;
        public Funcionario(string nome)
        {
            Nome=nome;
        }
        public virtual void SalarioFuncionario()
        {
            Salario = salarioMinimo;
        }
        public void AumentarID()
        {
            ID++;
        }
        public string MostrarID()
        {
            return $"{ID}";
        }
        public abstract void FuncaoFuncionario();
    }
}