using System;

namespace exer02
{
    class Program
    {
        static public string [] CPFs = new string [0];
        static public int Index = 0;
        static void Main(string[] args)
        {
            var relatorio = new Relatorio();
            Console.WriteLine("Deseja fazer a folha de pagamento de um funcionário? Sim/Não");
            string ler = Console.ReadLine();
            string cpf;
            while (ler.ToLower() == "sim")
            {
                Console.Write("Informe o CPF do funcionário (Use apenas números): ");
                string analiseCPF = Console.ReadLine();
                bool analiseTamanho = true;
                bool soNumeros = false;
                int verificar = 0;
                while (analiseTamanho != true || true != soNumeros)
                {
                    if (analiseCPF.Length == 11)
                    {
                        analiseTamanho = true;
                    } else
                    {
                        analiseTamanho = false;
                        Console.WriteLine("3RR0R: O CPF deve ter 11 caracteres inseridos");
                        Console.Write("Informe o CPF do funcionário (Use apenas números): ");
                        analiseCPF = Console.ReadLine();
                    }
                    for (int i = 0; i < analiseCPF.Length; i++)
                    {
                        int praDecimal = Convert.ToInt32(analiseCPF[i]);
                        if (praDecimal < 47 || praDecimal > 59)
                        {
                            Console.WriteLine("3RR0R: O CPF deve conter apenas números...");
                            soNumeros = false;
                            Console.Write("Informe o CPF do funcionário (Use apenas números): ");
                            analiseCPF = Console.ReadLine();
                        } else
                        {
                            verificar++;
                        }
                        if (verificar == analiseCPF.Length-1)
                        {
                            soNumeros = true;
                        }
                    }
                }
                cpf = $"{analiseCPF[0]}{analiseCPF[1]}{analiseCPF[2]}.{analiseCPF[3]}{analiseCPF[4]}{analiseCPF[5]}.{analiseCPF[6]}{analiseCPF[7]}{analiseCPF[8]}-{analiseCPF[9]}{analiseCPF[10]}";
                if (Index > 0)
                {
                    for (int i = 0; i < CPFs.Length; i++)
                    {
                        if (CPFs[i] == cpf)
                        {
                            i = 0;
                            Console.WriteLine("3RR0R: CPF já cadastrado!");
                            Console.Write("Informe o CPF do funcionário (Use apenas números): ");
                            analiseCPF = Console.ReadLine();
                            analiseTamanho = true;
                            soNumeros = false;
                            verificar = 0;
                            while (analiseTamanho != true || true != soNumeros)
                            {
                                if (analiseCPF.Length == 11)
                                {
                                    analiseTamanho = true;
                                } else
                                {
                                    analiseTamanho = false;
                                    Console.WriteLine("3RR0R: O CPF deve ter 11 caracteres inseridos");
                                    Console.Write("Informe o CPF do funcionário (Use apenas números): ");
                                    analiseCPF = Console.ReadLine();
                                }
                                for (int j = 0; j < analiseCPF.Length; j++)
                                {
                                    int praDecimal = Convert.ToInt32(analiseCPF[j]);
                                    if (praDecimal < 47 || praDecimal > 59)
                                    {
                                        Console.WriteLine("3RR0R: O CPF deve conter apenas números...");
                                        soNumeros = false;
                                        Console.Write("Informe o CPF do funcionário (Use apenas números): ");
                                        analiseCPF = Console.ReadLine();
                                    } else
                                    {
                                        verificar++;
                                    }
                                    if (verificar == analiseCPF.Length-1)
                                    {
                                        soNumeros = true;
                                    }
                                }
                            }
                        }
                        if (i == CPFs.Length-1)
                        {
                            cpf = $"{analiseCPF[0]}{analiseCPF[1]}{analiseCPF[2]}.{analiseCPF[3]}{analiseCPF[4]}{analiseCPF[5]}.{analiseCPF[6]}{analiseCPF[7]}{analiseCPF[8]}-{analiseCPF[9]}{analiseCPF[10]}";
                        }
                    }
                }
                Console.WriteLine(cpf);
                string [] tempCPFs = new string[CPFs.Length+1];
                for (int i=0; i < CPFs.Length; i++)
                {
                    tempCPFs[i] = CPFs[i];
                }
                CPFs = tempCPFs;
                CPFs[Index] = cpf;
                Index++;
                Console.Write("Informe o Nome do Funcionário: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual a Função que esse funcionário exerce? 1-Programador, 2-Suporte, 3-Diversos");
                Console.Write("Informe o número da opção desejada: ");
                ler = Console.ReadLine();
                int opt = Convert.ToInt32(ler);
                while (opt > 3 || opt < 1)
                {
                    Console.WriteLine("3RR0R: A opção escolhida não está disponível...");
                    Console.Write("Informe o número da opção desejada: ");
                    ler = Console.ReadLine();
                    opt = Convert.ToInt32(ler);
                }
                switch (opt)
                {
                    case 1:
                        Funcionario funcionarioProgramador = new Programador(cpf,nome);
                        funcionarioProgramador.SalarioFuncionario();
                        relatorio.AumentarRelatorio(funcionarioProgramador);
                    break;
                    case 2:
                        Funcionario funcionarioSuporte = new Suporte(cpf,nome);
                        funcionarioSuporte.SalarioFuncionario();
                        relatorio.AumentarRelatorio(funcionarioSuporte);
                    break;
                    case 3:
                        Funcionario funcionarioDiversos = new Diversos(cpf,nome);
                        funcionarioDiversos.SalarioFuncionario();
                        relatorio.AumentarRelatorio(funcionarioDiversos);
                    break;
                    default:
                        Console.WriteLine("Opção inválida");
                    break;
                }
                Console.WriteLine("Deseja fazer outra folha de pagamento de um funcionário? Sim/Não");
                ler = Console.ReadLine();
            }
            if (relatorio.getIndex() > 0)
            {
                relatorio.ExibirRelatorio();
            } else 
            {
                Console.WriteLine("O relatório de funcionário não pode ser exibido pois nenhum funcionário foi inserido...");
            }
        }
    }
}
