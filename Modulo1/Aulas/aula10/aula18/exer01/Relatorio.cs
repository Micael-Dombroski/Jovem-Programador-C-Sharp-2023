using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01
{
    public class Relatorio
    {
        public int index = 0;
        public string [,] relatorio = new string [0,10];
        private double TotalSalarios=0.0;
        public void AumentarRelatorio(Funcionario funcionario)
        {
            string [,] tempRelatorio = new string [index+1,10];
            for (int i = 0; i < index; i++)
            {
                tempRelatorio[i,0] = relatorio[i,0];
                tempRelatorio[i,1] = relatorio[i,1];
                tempRelatorio[i,2] = relatorio[i,2];
                tempRelatorio[i,3] = relatorio[i,3];
                tempRelatorio[i,4] = relatorio[i,4];
                tempRelatorio[i,5] = relatorio[i,5];
                tempRelatorio[i,6] = relatorio[i,6];
                tempRelatorio[i,7] = relatorio[i,7];
                tempRelatorio[i,8] = relatorio[i,8];
                tempRelatorio[i,9] = relatorio[i,9];
            }
            relatorio=tempRelatorio;
            if (funcionario.Tipo == 1)
            {
                TotalSalarios+=funcionario.Salario;
                relatorio[index,0] = funcionario.Cpf;
                relatorio[index,1] = funcionario.Nome;
                relatorio[index,2] = funcionario.Endereco.Estado;
                relatorio[index,3] = funcionario.Endereco.Cidade;
                relatorio[index,4] = funcionario.Endereco.Bairro;
                relatorio[index,5] = funcionario.Endereco.Rua;
                relatorio[index,6] = $"{funcionario.Endereco.Numero}";
                relatorio[index,7] = funcionario.Funcao;
                relatorio[index,8] = $"R$ {funcionario.Salario}";
                relatorio[index,9] = funcionario.MostrarID();
            } else 
            {
                TotalSalarios+=funcionario.Salario;
                relatorio[index,0] = funcionario.Cnpj;
                relatorio[index,1] = funcionario.Nome;
                relatorio[index,2] = funcionario.Endereco.Estado;
                relatorio[index,3] = funcionario.Endereco.Cidade;
                relatorio[index,4] = funcionario.Endereco.Bairro;
                relatorio[index,5] = funcionario.Endereco.Rua;
                relatorio[index,6] = $"{funcionario.Endereco.Numero}";
                relatorio[index,7] = funcionario.Funcao;
                relatorio[index,8] = $"R$ {funcionario.Salario}";
                relatorio[index,9] = funcionario.MostrarID();
            }
            index++;
        }
        public void ExibirRelatorio()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("===================Relatório===================");
            Console.WriteLine("===============================================\n");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"ID: {relatorio[i,9]}");
                if (relatorio[i,0].Length < 16)
                {
                    Console.WriteLine($"CPF: {relatorio[i,0]}");
                } else
                {
                    Console.WriteLine($"CNPJ: {relatorio[i,0]}");
                }
                Console.WriteLine($"Nome: {relatorio[i,1]}");
                Console.WriteLine($"Estado: {relatorio[i,2]}");
                Console.WriteLine($"Cidade: {relatorio[i,3]}");
                Console.WriteLine($"Bairro: {relatorio[i,4]}");
                Console.WriteLine($"Rua: {relatorio[i,5]}");
                Console.WriteLine($"Número: {relatorio[i,6]}");
                Console.WriteLine($"Função: {relatorio[i,7]}");
                Console.WriteLine($"Salário: {relatorio[i,8]}");
                Console.WriteLine();
            }
            Console.WriteLine("\n===============================================\n");
            Console.WriteLine($"Valor da Soma de todos os Salário: R$ {TotalSalarios}\n");
            Console.WriteLine("===============================================");
        }
    }
}