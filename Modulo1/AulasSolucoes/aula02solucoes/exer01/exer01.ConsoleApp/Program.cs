using System.Collections.Generic;
using System;
using exer01.Classes;

namespace exer01.ConsoleApp
{
    class Program
    {
        static List<Habitante> listaHabitantes = new List<Habitante>();
        static string ler;
        static string nome;
        static double salario;
        static int qtFilhos;
        static void Main(string[] args)
        {
            bool QtFil = true;
            bool CheckSalario = true;
            do 
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------Pesquisa Pre Censo-------------------------------");
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("Informe o Nome da pessoa entrevistada: ");
                nome = Console.ReadLine();
                do
                {
                    CheckSalario = true;
                    try
                    {
                        Console.Write("Informe o Salário da pessoa entrevistada: R$ ");
                        ler = Console.ReadLine();
                        int contVirgula=0;
                        for (int i = 0; i < ler.Length; i++)
                        {
                            int eNumero = ler[i];
                            if (i==0 && eNumero == 45)
                            {
                                CheckSalario = false;
                                throw new ArgumentException("Esse campo não pode receber valores negativos");
                            } else if ((eNumero <= 57 && eNumero >= 48) || eNumero == 44)
                            {
                                if (eNumero==44)
                                {
                                    contVirgula++;
                                    if (i+2 < ler.Length-1)
                                    {
                                        CheckSalario = false;
                                        throw new ArgumentException("O salário só pode possuir 2 casas decimais");
                                    }
                                }
                                if (contVirgula > 1)
                                {
                                    CheckSalario = false;
                                    throw new ArgumentException("O número só pode ter 1 vírgula para separar dos números dos decimais");
                                }
                            } else 
                            {
                                CheckSalario = false;
                                throw new ArgumentException("O salário deve ser descrito apenas com números");
                            }
                        }
                        salario = Convert.ToDouble(ler);
                    } catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (CheckSalario == false);
                do
                {
                    QtFil = true;
                    try
                    {
                        Console.Write("Informe a Quantidade de Filhos da pessoa entrevista: ");
                        ler = Console.ReadLine();
                        for (int i = 0; i < ler.Length; i++)
                        {
                            int eNumero = ler[i];
                            if (i == 0 && eNumero == 45)
                            {
                                QtFil = false;
                                throw new ArgumentException("Esse campo não pode receber valores negativos");
                            } else if (eNumero <= 57 && eNumero >= 48)
                            {
                            } else 
                            {
                                QtFil = false;
                                throw new ArgumentException("Esse campo só pode receber valores numéricos inteiros");
                            }
                        }
                        qtFilhos = Convert.ToInt32(ler);
                    } catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (QtFil == false);
                var habitante = new Habitante(nome,salario,qtFilhos);
                habitante.AcharMaiorSalario(habitante);
                habitante.AcharMenorSalario(habitante);
                habitante.AcharTotFilhos(habitante);
                habitante.AcharTotSalarios(habitante);
                habitante.PessoasAbaixoDeSalarioMinimo(habitante);
                listaHabitantes.Add(habitante);
                Console.WriteLine("Gostaria de fazer outra entrevista? Sim/Não");
                ler = Console.ReadLine();
                if (ler.ToLower() != "sim")
                {
                    habitante.AcharMediaQtFilhos();
                    habitante.AcharMediaSalarios();
                }
            } while(ler.ToLower() == "sim");
            Console.Clear();
            Console.WriteLine("Dados dos Entrevistados:");
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < listaHabitantes.Count; i++)
            {
                Console.WriteLine($"Nome do Entrevistado: {listaHabitantes[i].Nome}");
                Console.WriteLine($"Salário do Entrevistado: R$ {listaHabitantes[i].Salario}");
                Console.WriteLine($"Número de Filhos do Entrevistado: {listaHabitantes[i].QtFilhos}");
                Console.WriteLine("----------------------------------------------");
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------Resultados Obtidos-------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine($"A média do salário da população é: R$ {listaHabitantes[0].ExibirMediaSalarios()}");
            Console.WriteLine($"A média de filhos da população é: {listaHabitantes[0].ExibirMediaQtFilhos()}");
            Console.Write($"O maior salário registrado foi: R$ ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(listaHabitantes[0].ExibirMaiorSalario());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"O menor salário registrado foi: R$ ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(listaHabitantes[0].ExibirMenorSalario());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"O percentual de Pessoas que ganham abaixo de um Salário Mínimo é: {listaHabitantes[0].PercentualPessoasAbaixoDeSalarioMinimo()}%");
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}
