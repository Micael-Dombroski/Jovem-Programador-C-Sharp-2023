using System;

namespace exer01
{
    class Program
    {
        static string [] CPFs = new string [0];
        static string [] CNPJs = new string [0];
        static int Index = 0;
        static int Index2= 0;
        static void Main(string[] args)
        {
            Relatorio relatorio = new Relatorio();
            Console.WriteLine("Deseja fazer a folha de pagamento de um funcionário? Sim/Não");
            string ler = Console.ReadLine();
            string cnpj;
            string cpf;
            while (ler.ToLower() == "sim")
            {
                Console.WriteLine("O funcionário é: 1-Pessoa Física, 2-Pessoa Jurídica");
                Console.Write("Informe o número da opção escolhida: ");
                ler = Console.ReadLine();
                int tipo = Convert.ToInt32(ler);
                switch (tipo)
                {
                    case 1:
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
                                while (CPFs[i] == cpf)
                                {
                                    Console.WriteLine(CPFs[i]);
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
                                        cpf = $"{analiseCPF[0]}{analiseCPF[1]}{analiseCPF[2]}.{analiseCPF[3]}{analiseCPF[4]}{analiseCPF[5]}.{analiseCPF[6]}{analiseCPF[7]}{analiseCPF[8]}-{analiseCPF[9]}{analiseCPF[10]}";
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
                        Console.Write("Informe o nome da Rua onde esse funcionário mora: ");
                        string rua = Console.ReadLine();
                        Console.Write("Informe o número da Casa do funcionário: ");
                        ler = Console.ReadLine();
                        int numero = Convert.ToInt32(ler);
                        Console.Write("Informe o Bairro onde esse funcionário mora: ");
                        string bairro = Console.ReadLine();
                        Console.Write("Informe a Cidade em que esse funcionário mora: ");
                        string cidade = Console.ReadLine();
                        Console.Write("Informe o Estado em que esse funcionário mora: ");
                        string estado = Console.ReadLine();
                        ler = Convert.ToString(numero);
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
                                Funcionario funcionarioProgramador = new Programador(nome);
                                funcionarioProgramador.Cpf = cpf;
                                funcionarioProgramador.Tipo=1;
                                funcionarioProgramador.AumentarID();
                                Endereco endereco = new Endereco(rua,ler,bairro,cidade,estado);
                                funcionarioProgramador.Endereco=endereco;
                                funcionarioProgramador.SalarioFuncionario();
                                funcionarioProgramador.FuncaoFuncionario();
                                relatorio.AumentarRelatorio(funcionarioProgramador);
                            break;
                            case 2:
                                Funcionario funcionarioSuporte = new Suporte(nome);
                                funcionarioSuporte.Cpf = cpf;
                                funcionarioSuporte.Tipo=1;
                                funcionarioSuporte.AumentarID();
                                endereco = new Endereco(rua,ler,bairro,cidade,estado);
                                funcionarioSuporte.Endereco=endereco;
                                funcionarioSuporte.SalarioFuncionario();
                                funcionarioSuporte.FuncaoFuncionario();
                                relatorio.AumentarRelatorio(funcionarioSuporte);
                            break;
                            case 3:
                                Funcionario funcionarioDiversos = new Diversos(nome);
                                funcionarioDiversos.Cpf=cpf;
                                funcionarioDiversos.Tipo=1;
                                funcionarioDiversos.AumentarID();
                                endereco = new Endereco(rua,ler,bairro,cidade,estado);
                                funcionarioDiversos.Endereco=endereco;
                                funcionarioDiversos.SalarioFuncionario();
                                funcionarioDiversos.FuncaoFuncionario();
                                relatorio.AumentarRelatorio(funcionarioDiversos);
                            break;
                            default:
                                Console.WriteLine("Opção inválida");
                            break;
                        }
                    break;
                    case 2:
                        Console.Write("Informe o CNPJ do funcionário (Use apenas números): ");
                        string analiseCNPJ = Console.ReadLine();
                        bool analisetamanho = true;
                        bool soNumero = false;
                        int verifica = 0;
                        while (analisetamanho != true || true != soNumero)
                        {
                            if (analiseCNPJ.Length == 14)
                            {
                                analisetamanho = true;
                            } else
                            {
                                analisetamanho = false;
                                Console.WriteLine("3RR0R: O CNPJ deve ter 14 caracteres inseridos");
                                Console.Write("Informe o CPF do funcionário (Use apenas números): ");
                                analiseCNPJ = Console.ReadLine();
                            }
                            for (int i = 0; i < analiseCNPJ.Length; i++)
                            {
                                int pradecimal = Convert.ToInt32(analiseCNPJ[i]);
                                if (pradecimal < 47 || pradecimal > 59)
                                {
                                    Console.WriteLine("3RR0R: O CNPJ deve conter apenas números...");
                                    soNumeros = false;
                                    Console.Write("Informe o CNPJ do funcionário (Use apenas números): ");
                                    analiseCPF = Console.ReadLine();
                                } else
                                {
                                    verifica++;
                                }
                                if (verifica == analiseCNPJ.Length-1)
                                {
                                    soNumero = true;
                                }
                            }
                        }
                        cnpj = $"{analiseCNPJ[0]}{analiseCNPJ[1]}.{analiseCNPJ[2]}{analiseCNPJ[3]}{analiseCNPJ[4]}.{analiseCNPJ[5]}{analiseCNPJ[6]}{analiseCNPJ[7]}/{analiseCNPJ[8]}{analiseCNPJ[9]}{analiseCNPJ[10]}{analiseCNPJ[11]}-{analiseCNPJ[12]}{analiseCNPJ[13]}";
                        if (Index2 > 0)
                        {
                            for (int i = 0; i < CNPJs.Length; i++)
                            {
                                while (CNPJs[i] == cnpj)
                                {
                                    Console.WriteLine(CNPJs[i]);
                                    i = 0;
                                    Console.WriteLine("3RR0R: CNPJ já cadastrado!");
                                    Console.Write("Informe o CNPJ do funcionário (Use apenas números): ");
                                    analiseCNPJ = Console.ReadLine();
                                    analisetamanho = true;
                                    soNumero = false;
                                    verifica = 0;
                                    while (analisetamanho != true || true != soNumero)
                                    {
                                        if (analiseCNPJ.Length == 14)
                                        {
                                            analiseTamanho = true;
                                        } else
                                        {
                                            analiseTamanho = false;
                                            Console.WriteLine("3RR0R: O CNPJ deve ter 14 caracteres inseridos");
                                            Console.Write("Informe o CNPJ do funcionário (Use apenas números): ");
                                            analiseCPF = Console.ReadLine();
                                        }
                                        for (int j = 0; j < analiseCNPJ.Length; j++)
                                        {
                                            int pradecimal = Convert.ToInt32(analiseCNPJ[j]);
                                            if (pradecimal < 47 || pradecimal > 59)
                                            {
                                                Console.WriteLine("3RR0R: O CNPJ deve conter apenas números...");
                                                soNumeros = false;
                                                Console.Write("Informe o CNPJ do funcionário (Use apenas números): ");
                                                analiseCPF = Console.ReadLine();
                                            } else
                                            {
                                                verifica++;
                                            }
                                            if (verifica == analiseCNPJ.Length-1)
                                            {
                                                soNumero = true;
                                            }
                                        }
                                        cnpj = $"{analiseCNPJ[0]}{analiseCNPJ[1]}.{analiseCNPJ[2]}{analiseCNPJ[3]}{analiseCNPJ[4]}.{analiseCNPJ[5]}{analiseCNPJ[6]}{analiseCNPJ[7]}/{analiseCNPJ[8]}{analiseCNPJ[9]}{analiseCNPJ[10]}{analiseCNPJ[11]}-{analiseCNPJ[12]}{analiseCNPJ[13]}";
                                    }
                                }
                                if (i == CNPJs.Length-1)
                                {
                                    cnpj = $"{analiseCNPJ[0]}{analiseCNPJ[1]}.{analiseCNPJ[2]}{analiseCNPJ[3]}{analiseCNPJ[4]}.{analiseCNPJ[5]}{analiseCNPJ[6]}{analiseCNPJ[7]}/{analiseCNPJ[8]}{analiseCNPJ[9]}{analiseCNPJ[10]}{analiseCNPJ[11]}-{analiseCNPJ[12]}{analiseCNPJ[13]}";
                                }
                            }
                        }
                        Console.WriteLine(cnpj);
                        string [] tempCNPJs = new string[CNPJs.Length+1];
                        for (int i=0; i < CNPJs.Length; i++)
                        {
                            tempCNPJs[i] = CNPJs[i];
                        }
                        CNPJs = tempCNPJs;
                        CNPJs[Index2] = cnpj;
                        Index2++;
                        Console.Write("Informe o Nome do Funcionário: ");
                        nome = Console.ReadLine();
                        Console.Write("Informe o nome da Rua onde esse funcionário mora: ");
                        rua = Console.ReadLine();
                        Console.Write("Informe o número da Casa do funcionário: ");
                        ler = Console.ReadLine();
                        numero = Convert.ToInt32(ler);
                        Console.Write("Informe o Bairro onde esse funcionário mora: ");
                        bairro = Console.ReadLine();
                        Console.Write("Informe a Cidade em que esse funcionário mora: ");
                        cidade = Console.ReadLine();
                        Console.Write("Informe o Estado em que esse funcionário mora: ");
                        estado = Console.ReadLine();
                        ler = Convert.ToString(numero);
                        Console.WriteLine("Qual a Função que esse funcionário exerce? 1-Programador, 2-Suporte, 3-Diversos");
                        Console.Write("Informe o número da opção desejada: ");
                        ler = Console.ReadLine();
                        opt = Convert.ToInt32(ler);
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
                                Funcionario funcionarioProgramador = new Programador(nome);
                                funcionarioProgramador.Cnpj = cnpj;
                                funcionarioProgramador.Tipo=2;
                                funcionarioProgramador.AumentarID();
                                Endereco endereco = new Endereco(rua,ler,bairro,cidade,estado);
                                funcionarioProgramador.Endereco=endereco;
                                funcionarioProgramador.SalarioFuncionario();
                                funcionarioProgramador.FuncaoFuncionario();
                                relatorio.AumentarRelatorio(funcionarioProgramador);
                            break;
                            case 2:
                                Funcionario funcionarioSuporte = new Suporte(nome);
                                funcionarioSuporte.Cnpj = cnpj;
                                funcionarioSuporte.Tipo=2;
                                funcionarioSuporte.AumentarID();
                                endereco = new Endereco(rua,ler,bairro,cidade,estado);
                                funcionarioSuporte.Endereco=endereco;
                                funcionarioSuporte.SalarioFuncionario();
                                funcionarioSuporte.FuncaoFuncionario();
                                relatorio.AumentarRelatorio(funcionarioSuporte);
                            break;
                            case 3:
                                Funcionario funcionarioDiversos = new Diversos(nome);
                                funcionarioDiversos.Cnpj = cnpj;
                                funcionarioDiversos.Tipo=2;
                                funcionarioDiversos.AumentarID();
                                endereco = new Endereco(rua,ler,bairro,cidade,estado);
                                funcionarioDiversos.Endereco=endereco;
                                funcionarioDiversos.SalarioFuncionario();
                                funcionarioDiversos.FuncaoFuncionario();
                                relatorio.AumentarRelatorio(funcionarioDiversos);
                            break;
                            default:
                                Console.WriteLine("Opção inválida");
                            break;
                        }
                    break;
                    default:
                        Console.WriteLine("Opção inválida...");
                    break;
                }
                        
                Console.WriteLine("Deseja fazer outra folha de pagamento de um funcionário? Sim/Não");
                ler = Console.ReadLine();
            }
            relatorio.ExibirRelatorio();
        }
    }
}
