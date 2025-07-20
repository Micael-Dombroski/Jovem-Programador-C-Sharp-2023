using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02
{
    public class Relatorio
    {
        private int index = 0;
        private string [] relatorio = new string[0];
        private double TotalGeral = 0.0;
        public void AumentarRelatorio(Funcionario funcionario)
        {
            string [] tempRelatorio = new string[relatorio.Length+1];
            for (int i = 0; i < relatorio.Length; i++)
            {
                tempRelatorio[i] = relatorio[i];
            }
            relatorio=tempRelatorio;
            TotalGeral += funcionario.Salario;
            relatorio[index] = $"CPF: {funcionario.Cpf} - Nome: {funcionario.Nome} - Função: {funcionario.Funcao} - Salário: R$ {funcionario.Salario}";
            index++;
        }
        public  void ExibirRelatorio()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("===================Relatório===================");
            Console.WriteLine("===============================================\n");
            for (int i = 0; i < relatorio.Length; i++)
            {
                Console.WriteLine(relatorio[i]);
                Console.WriteLine();
            }
            Console.WriteLine("\n===============================================\n");
            Console.WriteLine($"Valor da Soma de todos os Salário: R$ {TotalGeral}\n");
            Console.WriteLine("===============================================");
        }
        public int getIndex()
        {
            return index;
        }
    }
}