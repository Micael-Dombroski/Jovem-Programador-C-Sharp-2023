using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer04
{
    public abstract class Funcionario
    {
        public string Nome;
        protected double SalarioMinimo = 1320.00;
        protected double Salario;
        protected string Cargo;
        protected double ImpostoDeRenda=0.0;
        public Funcionario (string nome) {
            Nome = nome;
        }
        public abstract void DefinirCargo();
        public abstract void DefinirSalario();
        public virtual double MostrarSalario()
        {
            return Salario;
        }
        public virtual double CalculoIR()
        {
            if (Salario > 2112.00)
            {
                double valorAcima = Salario - 2112.00;
                if (valorAcima < 714.65)
                {
                    ImpostoDeRenda = valorAcima*0.075;
                } else
                {
                    ImpostoDeRenda = 714.65*0.075;//53.60
                    valorAcima = valorAcima-714.65;
                    if (valorAcima < 924.40)
                    {
                        ImpostoDeRenda+=valorAcima*0.15;
                    } else
                    {
                        ImpostoDeRenda += 924.40*0.15;//138.66
                        valorAcima = valorAcima - 924.40;
                        if (valorAcima < 913.63)
                        {
                            ImpostoDeRenda+=valorAcima*0.225;
                        } else
                        {
                            ImpostoDeRenda += 913.63*0.225;//205,56
                            valorAcima=valorAcima - 913.63;
                            ImpostoDeRenda+=valorAcima*0.275;
                        }
                    }
                }
            }
            return ImpostoDeRenda;
        }
        public void ExibirInfosDoIR(Funcionario funcionario)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("==Calculando o Imposto de Renda==");
            Console.WriteLine("=================================\n");
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Cargo: {funcionario.Cargo}");
            Console.WriteLine($"Salário: R$ {funcionario.Salario}");
            Console.WriteLine($"Imposto de Renda: R$ {funcionario.ImpostoDeRenda}");
            Console.WriteLine("\n=================================\n");
        }
    }
}