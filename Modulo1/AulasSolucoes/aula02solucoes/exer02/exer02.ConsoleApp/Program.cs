using System.Collections.Generic;
using System;
using exer02.Classes;

namespace exer02.ConsoleApp
{
    class Program
    {
        static string cnpj;
        static string cpf;
        static string analiseCPF;
        static string analiseCNPJ;
        static string nome;
        static string rua;
        static int numero;
        static string bairro;
        static string cidade;
        static string estado;
        static int opt;
        static int optMenu;
        static Relatorio relatorio = new Relatorio();
        static List<Funcionario> listaFuncionarios = new List<Funcionario>();
        static List<Empregado> listaEmpregados = new List<Empregado>();
        static List<PrestadorDServico> listaPrestadoresDServico = new List<PrestadorDServico>();
        static string ler;
        static int tipo;
        static int index;
        static void Main(string[] args)
        {
            do 
            {
                Console.WriteLine("========================================");
                Console.WriteLine("==================Menu==================");
                Console.WriteLine("========================================");
                Console.WriteLine("1 - Gerenciar Empregados");
                Console.WriteLine("2 - Gerenciar Prestadores de Serviço");
                Console.WriteLine("3 - Total de Valores a serem Pagos");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("========================================");
                Console.Write("Escolha uma das opções do Menu: ");
                ler = Console.ReadLine();
                opt = Convert.ToInt32(ler);
                optMenu = opt;
                if (opt == 1)
                {
                    tipo = 1;
                } else if (opt == 2)
                {
                    tipo = 2;
                }
                switch (opt)
                {
                    case 1:
                        ExibirMenu();
                    break;
                    case 2:
                        ExibirMenu();
                    break;
                    case 3:
                        double totalASerPago = 0.0;

                            for (int i = 0; i < listaFuncionarios.Count; i++)
                            {
                                totalASerPago += listaFuncionarios[i].Salario;
                            }

                        Console.WriteLine($"O Total de Valores a serem pagos é: R$ {totalASerPago}");
                    break;
                    case 4:
                        Console.WriteLine("Saindo...");
                    break;
                }
            } while (optMenu != 4);
        }


        static bool ValCPF(string Cpf)
        {
            try
            {
                Console.WriteLine(Cpf.Length);
                if (Cpf.Length < 11 || Cpf.Length > 11)
                {
                    throw new ArgumentException("O número de caracteres inseridos não bate com a quantidade que essa informação exige");;
                }
                for (int i = 0; i < Cpf.Length; i++)
                {
                    if (Cpf[i] < 48 || Cpf[i] > 57)
                    {
                        throw new ArgumentException("Use apenas números nessa informação");
                    }
                }
                 Console.WriteLine("CPF válido");
                return true;
            } catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        static bool ValCNPJ(string Cnpj)
        {
            try 
            {
                Console.WriteLine(Cnpj.Length);
                if (Cnpj.Length < 14 || Cnpj.Length > 14)
                {
                    throw new ArgumentException("O número de caracteres inseridos não bate com a quantidade que essa informação exige");;
                }
                for (int i = 0; i < Cnpj.Length; i++)
                {
                    if (Cnpj[i] < 48 || Cnpj[i] > 57)
                    {
                        throw new ArgumentException("Use apenas números nessa informação");
                    }
                }
                 Console.WriteLine("CNPJ válido");
                return true;
            } catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        static void ExibirMenu()
        {
            int opcaoMenu = 0;
            do {

            Console.WriteLine("==========================================");
            if (opt == 1)
            {
                Console.WriteLine("===========Menu do Empregado============");
            } else if (opt == 2)
            {
                Console.WriteLine("=======Menu do Prestador de Serviço=======");
            }
            Console.WriteLine("==========================================");
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Editar");
            Console.WriteLine("3 - Listar");
            if (opt == 1)
            {
                Console.WriteLine("4 - Consultar por cpf");
            } else if (opt == 2)
            {
                Console.WriteLine("4 - Consultar por cpf e cnpj");
            }
            Console.WriteLine("5 - Excluir");
            Console.WriteLine("6 - Voltar");
            Console.WriteLine("==========================================");

            Console.Write("Selecione a Opção Desejada: ");
            opcaoMenu = Int32.Parse(Console.ReadLine());

            switch (opcaoMenu)
            {
                case 1:
                    cpf = "";
                    cnpj = "";
                    int opcao;
                    //Adicionando Funcionário
                    if (tipo == 1)
                    {
                        //Solicitando CPF
                        Console.WriteLine(listaFuncionarios.Count);
                        if (listaFuncionarios.Count == 0)
                        {
                            do {
                                Console.Write("Digite o CPF do Funcionário: ");
                                cpf = Console.ReadLine();
                            } while (ValCPF(cpf) == false);
                        } else
                        {
                            bool repetido = false;
                            do
                            {
                                repetido = false;
                                try
                                {
                                    do {
                                        Console.Write("Digite o CPF do Funcionário: ");
                                        cpf = Console.ReadLine();
                                    } while (ValCPF(cpf) == false);
                                    for (int i = 0; i < listaFuncionarios.Count; i++)
                                    {
                                        if (cpf == listaFuncionarios[i].Cpf)
                                        {
                                            repetido = true;
                                            throw new ArgumentException("CPF já cadastrado");
                                        }
                                    }
                                } catch (ArgumentException e)
                                {
                                    Console.WriteLine(e.Message);

                                }
                            } while (repetido == true);     
                        }
                    } else if (tipo == 2)
                    {
                        Console.WriteLine("O Funcionário é: 1-Pessoa Física, 2-Pessoa Jurídica");
                        Console.WriteLine("Informe o número da opção desejada: ");
                        ler = Console.ReadLine();
                        opcao = Convert.ToInt32(ler);
                        if (opcao == 1)
                        {
                            //Solicitando CPF
                            Console.WriteLine(listaFuncionarios.Count);
                            if (listaFuncionarios.Count == 0)
                            {
                                do {
                                    Console.Write("Digite o CPF do Funcionário: ");
                                    cpf = Console.ReadLine();
                                } while (ValCPF(cpf) == false);
                            } else
                            {
                                bool repetido = false;
                                do
                                {
                                    repetido = false;
                                    try
                                    {
                                        do
                                        {
                                            Console.Write("Digite o CPF do Funcionário: ");
                                            cpf = Console.ReadLine();
                                        } while (ValCPF(cpf)==false);
                                        for (int i = 0; i < listaFuncionarios.Count; i++)
                                        {
                                            if (cpf == listaFuncionarios[i].Cpf)
                                            {
                                                repetido = true;
                                                throw new ArgumentException("CPF já cadastrado");
                                            }
                                        }
                                    } catch (ArgumentException e)
                                    {
                                        Console.WriteLine(e.Message);

                                    }
                                } while (repetido == true); 
                            }
                        } else if (opcao == 2)
                        {
                            //Solicitando CNPJ
                            Console.WriteLine(listaFuncionarios.Count);
                            if (listaFuncionarios.Count == 0)
                            {
                                do {
                                    Console.Write("Digite o CNPJ do Funcionário: ");
                                    cnpj = Console.ReadLine();
                                } while (ValCNPJ(cnpj) == false);
                            } else
                            {
                                bool repetido = false;
                                do
                                {
                                    repetido = false;
                                    try
                                    {
                                        do
                                        {
                                            Console.Write("Digite o CNPJ do Funcionário: ");
                                            cnpj = Console.ReadLine();
                                        } while (ValCNPJ(cnpj)==false);
                                        for (int i = 0; i < listaFuncionarios.Count; i++)
                                        {
                                            if (cnpj == listaFuncionarios[i].Cnpj)
                                            {
                                                repetido = true;
                                                throw new ArgumentException("CNPJ já cadastrado");
                                            }
                                        }
                                    } catch (ArgumentException e)
                                    {
                                        Console.WriteLine(e.Message);

                                    }
                                } while (repetido == true); 
                            }
                        }
                    }
                           
                    //Solicitando Nome
                    Console.Write("Digite o Nome do Funcionário: ");
                    nome = Console.ReadLine();

                    //Solicitando Informações de Endereço

                    //Rua
                    Console.Write("Digite a Rua do Funcionário: ");
                    rua = Console.ReadLine();

                    //Número da Residência
                    Console.Write("Digite o Número da Residência do Funcionário: ");
                    numero = Int32.Parse(Console.ReadLine());

                    //Bairro
                    Console.Write("Digite o Bairro do Funcionário: ");
                    bairro = Console.ReadLine();

                    //Cidade
                    Console.Write("Digite a Cidade do Funcionário: ");
                    cidade = Console.ReadLine();

                    //Estado
                    Console.Write("Digite o Estado do Funcionário: ");
                    estado = Console.ReadLine();

                    Endereco endereco = new Endereco(rua, $"{numero}", bairro, cidade, estado);

                    //Cargo Funcionário
                    Console.WriteLine("Digite o número do Cargo do Funcionário: 1-Programador, 2-Suporte, 3-Diversos");
                    int opcaoCargo = Int32.Parse(Console.ReadLine());

                    switch(opcaoCargo)
                    {
                        case 1:
                            if (tipo == 1)
                            {
                                EmpregadoProgramador programadorE = new EmpregadoProgramador(cpf, nome, endereco);
                                programadorE.FuncaoFuncionario();
                                programadorE.SalarioFuncionario();
                                
                                listaEmpregados.Add(programadorE);
                                listaFuncionarios.Add(programadorE);
                                index++;

                                Console.WriteLine("");
                            } else if (tipo == 2)
                            {
                                PrestadorDServicoProgramador programadorP = new PrestadorDServicoProgramador(nome, endereco);
                                programadorP.FuncaoFuncionario();
                                programadorP.SalarioFuncionario();
                                if (cpf.Length != 0)
                                {
                                    programadorP.Cpf = cpf;
                                } else if (cnpj.Length != 0)
                                {
                                    programadorP.Cnpj = cnpj;
                                }
                                listaPrestadoresDServico.Add(programadorP);
                                listaFuncionarios.Add(programadorP);
                                index++;
                                Console.WriteLine("");
                            }
                                
                        break;
                        case 2:

                            Console.WriteLine("");
                            if (tipo == 1)
                            {
                                EmpregadoSuporte suporteE = new EmpregadoSuporte(cpf, nome, endereco);
                                suporteE.FuncaoFuncionario();
                                suporteE.SalarioFuncionario();
                                
                                listaEmpregados.Add(suporteE);
                                listaFuncionarios.Add(suporteE);
                                index++;

                                Console.WriteLine("");
                            } else if (tipo == 2)
                            {
                                PrestadorDServicoSuporte suporteP = new PrestadorDServicoSuporte(nome, endereco);
                                suporteP.FuncaoFuncionario();
                                suporteP.SalarioFuncionario();
                                if (cpf.Length != 0)
                                {
                                    suporteP.Cpf = cpf;
                                } else if (cnpj.Length != 0)
                                {
                                    suporteP.Cnpj = cnpj;
                                }
                                listaPrestadoresDServico.Add(suporteP);
                                listaFuncionarios.Add(suporteP);
                                index++;
    
                                    Console.WriteLine("");
                            }
                        break;
                        case 3:
                            Console.WriteLine("");
                            if (tipo == 1)
                            {
                                EmpregadoDiversos diversosE = new EmpregadoDiversos(cpf, nome, endereco);
                                diversosE.FuncaoFuncionario();
                                diversosE.SalarioFuncionario();
                                
                                listaEmpregados.Add(diversosE);
                                listaFuncionarios.Add(diversosE);
                                index++;

                                Console.WriteLine("");
                            } else if (tipo == 2)
                            {
                                PrestadorDServicoDiversos diversosP = new PrestadorDServicoDiversos(nome, endereco);
                                diversosP.FuncaoFuncionario();
                                diversosP.SalarioFuncionario();
                                if (cpf.Length != 0)
                                {
                                    diversosP.Cpf = cpf;
                                } else if (cnpj.Length != 0)
                                {
                                    diversosP.Cnpj = cnpj;
                                }
                                listaPrestadoresDServico.Add(diversosP);
                                listaFuncionarios.Add(diversosP);
                                index++;

                                Console.WriteLine("");
                            }

                        break;
                        default:
                            Console.WriteLine("3RR0R: Opção Inválida!");
                            Console.WriteLine("");

                        break;
                    }
                Console.WriteLine("Funcionário Cadastrado com Sucesso!");
                Console.WriteLine("");
                break;
                case 2:
                    bool editarNome = false;
                    bool editarCpf = false;
                    bool editarCnpj = false;
                    bool editarEndereco = false;
                    Endereco enderecoEditado = new Endereco("","","","","");
                    if (tipo == 1)
                    {
                        //Solicitando o CPF para editar
                        do {
                            Console.Write("Digite o CPF do Funcionário que você deseja editar: ");
                            cpf = Console.ReadLine();
                            ValCPF(cpf);
                        } while (ValCPF(cpf) == false);
                        editarNome = false;
                        editarCpf = false;
                        editarCnpj = false;
                        editarEndereco = false;
                        bool jaCadastrado = false;
                        for (int i = 0; i < listaFuncionarios.Count; i++)
                        {
                            if (listaFuncionarios[i].Cpf == cpf)
                            {
                                jaCadastrado = true;
                            }
                            if (i == listaFuncionarios.Count-1 && jaCadastrado == false)
                            {
                                Console.WriteLine("Funcionário não cadastrado");
                            }
                        }
                        for (int i = 0; i < listaFuncionarios.Count; i++)
                        {
                            int localizar = 0;
                            for (int j = 0; j < listaEmpregados.Count; j++)
                            {
                                if (cpf == listaEmpregados[j].Cpf)
                                {
                                    localizar = j;
                                }
                            }
                            if (cpf == listaFuncionarios[i].Cpf)
                            {
                                Console.WriteLine("Funcionário Localizado!");
                                Console.WriteLine("Deseja editar o CPF do Funcionário? S/N");
                                ler = Console.ReadLine();
                                if (ler.ToLower() == "s")
                               {
                                    editarCpf = true;
                                    bool repetido = false;
                                    do
                                    {
                                        repetido = false;
                                        try
                                        {
                                            do {
                                                cpf = "";
                                                Console.Write("Digite o novo CPF do Funcionário: ");
                                                cpf = Console.ReadLine();
                                            } while (ValCPF(cpf) == false);
                                            foreach (Funcionario funcionario in listaFuncionarios)
                                            {
                                                if (funcionario.Cpf.Equals(cpf))
                                                {
                                                    repetido = true;
                                                    throw new ArgumentException("CPF já cadastrado");
                                                }
                                            }
                                        } catch (ArgumentException e)
                                        {
                                            Console.WriteLine(e.Message);
                                        }
                                    } while (repetido == true);
                               }
                               Console.WriteLine("Deseja editar o Nome do Funcionário? S/N");
                               ler = Console.ReadLine();
                               if (ler.ToLower() == "s")
                               {
                                    editarNome = true;
                                    Console.Write("Informe o Novo Nome do Funcionário: ");
                                    nome = Console.ReadLine();
                                    listaFuncionarios[i].Nome = nome;
                                    listaEmpregados[localizar].Nome = nome;
                               }
                               Console.WriteLine("Deseja editar o Endereço do Funcionário? S/N");
                               ler = Console.ReadLine();
                               if (ler.ToLower() == "s")
                               {
                                    editarEndereco = true;
                                    //Solicitando as Novas Informações de Endereço

                                        //Rua
                                        Console.Write("Digite a Rua do Funcionário: ");
                                        rua = Console.ReadLine();
                                        listaEmpregados[localizar].Endereco.Rua = rua;

                                        //Número da Residência
                                        Console.Write("Digite o Número da Residência do Funcionário: ");
                                        numero = Int32.Parse(Console.ReadLine());
                                        listaEmpregados[localizar].Endereco.Numero = $"{numero}";

                                        //Bairro
                                        Console.Write("Digite o Bairro do Funcionário: ");
                                        bairro = Console.ReadLine();
                                        listaEmpregados[localizar].Endereco.Bairro = bairro;

                                        //Cidade
                                        Console.Write("Digite a Cidade do Funcionário: ");
                                        cidade = Console.ReadLine();
                                        listaEmpregados[localizar].Endereco.Cidade = cidade;

                                        //Estado
                                        Console.Write("Digite o Estado do Funcionário: ");
                                        estado = Console.ReadLine();
                                        listaEmpregados[localizar].Endereco.Estado = estado;

                               }
                               Console.WriteLine("Deseja editar o Cargo do Funcionário? S/N");
                               ler = Console.ReadLine();
                               if (ler.ToLower() == "s")
                               {
                                    Console.WriteLine("Digite o número do Novo Cargo do Funcionário: 1-Programador, 2-Suporte, 3-Diversos");
                                    opcaoCargo = Int32.Parse(Console.ReadLine());
                                    if (editarCpf == false)
                                    {
                                        cpf = listaFuncionarios[i].Cpf;
                                    }
                                    if (editarNome == false)
                                    {
                                        nome = listaFuncionarios[i].Nome;
                                    }
                                    if (editarEndereco == false)
                                    {
                                        enderecoEditado = listaFuncionarios[i].Endereco;
                                    } else
                                    {
                                        enderecoEditado = listaEmpregados[localizar].Endereco;
                                    }
                                    switch(opcaoCargo)
                                    {
                                        case 1:
                                            if (tipo == 1)
                                            {    
                                                EmpregadoProgramador programadorE = new EmpregadoProgramador(cpf, nome, enderecoEditado);
                                                programadorE.FuncaoFuncionario();
                                                programadorE.SalarioFuncionario();
                                                listaFuncionarios[i] = programadorE;
                                                listaEmpregados[localizar] = programadorE;

                                                index++;

                                                Console.WriteLine("");
                                            }

                                        break;
                                        case 2:

                                            Console.WriteLine("");
                                            if (tipo == 1)
                                            {
                                                EmpregadoSuporte suporteE = new EmpregadoSuporte(cpf, nome, enderecoEditado);
                                                suporteE.FuncaoFuncionario();
                                                suporteE.SalarioFuncionario();
                                                listaFuncionarios[i] = suporteE;
                                                listaEmpregados[localizar] = suporteE;
                                
                                                index++;

                                                Console.WriteLine("");
                                            }
                                        break;
                                        case 3:
                                            Console.WriteLine("");
                                            if (tipo == 1)
                                            {
                                                EmpregadoDiversos diversosE = new EmpregadoDiversos(cpf, nome, enderecoEditado);
                                                diversosE.FuncaoFuncionario();
                                                diversosE.SalarioFuncionario();
                                                listaFuncionarios[i] = diversosE;
                                                listaEmpregados[localizar] = diversosE;
                                
                                
                                                index++;

                                                Console.WriteLine("");
                                            }

                                        break;
                                        default:
                                            Console.WriteLine("3RR0R: Opção Inválida!");
                                            Console.WriteLine("");

                                        break;
                                    }
                               }
                            }
                        }
                        
                    } else if (tipo == 2)
                    {
                        Console.WriteLine("O Funcionário é: 1-Pessoa Física, 2-Pessoa Jurídica");
                        Console.Write("Informe o número da opção desejada: ");
                        ler = Console.ReadLine();
                        opt = Convert.ToInt32(ler);
                        if (opt == 1)
                        {
                            //Solicitando o CPF para editar
                            do {
                                Console.Write("Digite o CPF do Funcionário que você deseja editar: ");
                                cpf = Console.ReadLine();
                                ValCPF(cpf);
                            } while (ValCPF(cpf) == false);
                            editarNome = false;
                            editarCpf = false;
                            editarEndereco = false;
                            bool jaCadastrado = false;
                            for (int i = 0; i < listaFuncionarios.Count; i++)
                            {
                                if (listaFuncionarios[i].Cpf == cpf)
                                {
                                    jaCadastrado = true;
                                }
                                if (i == listaFuncionarios.Count-1 && jaCadastrado == false)
                                {
                                    Console.WriteLine("Funcionário não cadastrado");
                                }
                            }
                            for (int i = 0; i < listaFuncionarios.Count; i++)
                            {
                                int localizar = 0;
                                for (int j = 0; j < listaPrestadoresDServico.Count; j++)
                                {
                                    if (cpf == listaPrestadoresDServico[j].Cpf)
                                    {
                                        localizar = j;
                                    }
                                }
                                if (cpf == listaFuncionarios[i].Cpf)
                                {
                                    Console.WriteLine("Funcionário Localizado!");
                                    Console.WriteLine("Deseja editar o CPF do Funcionário? S/N");
                                    ler = Console.ReadLine();
                                    if (ler.ToLower() == "s")
                                   {
                                        editarCpf = true;
                                        bool repetido = false;
                                        do
                                        {
                                            repetido = false;
                                            do
                                            {
                                                repetido = false;
                                                try
                                                {
                                                    do {
                                                        Console.Write("Digite o novo CPF do Funcionário: ");
                                                        cpf = Console.ReadLine();
                                                    } while (ValCPF(cpf) == false);
                                                    foreach (Funcionario funcionario in listaFuncionarios)
                                                    {
                                                        if (funcionario.Cpf.Equals(cpf))
                                                        {
                                                            repetido = true;
                                                            throw new ArgumentException("CPF já cadastrado");
                                                        }
                                                    }
                                                } catch (ArgumentException e)
                                                {
                                                    Console.WriteLine(e.Message);
                                                }
                                            } while (repetido == true);
                                        } while (repetido == true);
                                   }
                                   Console.WriteLine("Deseja editar o Nome do Funcionário? S/N");
                                   ler = Console.ReadLine();
                                   if (ler.ToLower() == "s")
                                   {
                                        editarNome = true;
                                        Console.Write("Informe o Novo Nome do Funcionário: ");
                                        nome = Console.ReadLine();
                                        listaFuncionarios[i].Nome = nome;
                                        listaPrestadoresDServico[localizar].Nome = nome;
                                   }
                                   Console.WriteLine("Deseja editar o Endereço do Funcionário? S/N");
                                   ler = Console.ReadLine();
                                   if (ler.ToLower() == "s")
                                   {
                                        editarEndereco = true;
                                        //Solicitando as Novas Informações de Endereço

                                        //Rua
                                        Console.Write("Digite a Rua do Funcionário: ");
                                        rua = Console.ReadLine();
                                        listaPrestadoresDServico[localizar].Endereco.Rua = rua;

                                        //Número da Residência
                                        Console.Write("Digite o Número da Residência do Funcionário: ");
                                        numero = Int32.Parse(Console.ReadLine());
                                        listaPrestadoresDServico[localizar].Endereco.Numero = $"{numero}";

                                        //Bairro
                                        Console.Write("Digite o Bairro do Funcionário: ");
                                        bairro = Console.ReadLine();
                                        listaPrestadoresDServico[localizar].Endereco.Bairro = bairro;

                                        //Cidade
                                        Console.Write("Digite a Cidade do Funcionário: ");
                                        cidade = Console.ReadLine();
                                        listaPrestadoresDServico[localizar].Endereco.Cidade = cidade;

                                        //Estado
                                        Console.Write("Digite o Estado do Funcionário: ");
                                        estado = Console.ReadLine();
                                        listaPrestadoresDServico[localizar].Endereco.Estado = estado;
                                        
                                   }
                                   Console.WriteLine("Deseja editar o Cargo do Funcionário? S/N");
                                   ler = Console.ReadLine();
                                   if (ler.ToLower() == "s")
                                   {
                                        Console.WriteLine("Digite o número do Novo Cargo do Funcionário: 1-Programador, 2-Suporte, 3-Diversos");
                                        opcaoCargo = Int32.Parse(Console.ReadLine());
                                        if (editarCpf == false)
                                        {
                                            cpf = listaFuncionarios[i].Cpf;
                                        }
                                        if (editarNome == false)
                                        {
                                            nome = listaFuncionarios[i].Nome;
                                        }
                                        if (editarEndereco == false)
                                        {
                                            enderecoEditado = listaFuncionarios[i].Endereco;
                                        } else 
                                        {
                                            enderecoEditado = listaPrestadoresDServico[localizar].Endereco;
                                        }
                                        switch(opcaoCargo)
                                        {
                                            case 1:
                                                if (tipo == 1)
                                                {    
                                                    PrestadorDServicoProgramador programadorP = new PrestadorDServicoProgramador(nome, enderecoEditado);
                                                    programadorP.FuncaoFuncionario();
                                                    programadorP.SalarioFuncionario();
                                                    programadorP.Cpf = cpf;
                                                    listaFuncionarios[i] = programadorP;
                                                    listaPrestadoresDServico[localizar] = programadorP;

                                                    index++;

                                                    Console.WriteLine("");
                                                }

                                            break;
                                            case 2:

                                                Console.WriteLine("");
                                                if (tipo == 1)
                                                {
                                                    PrestadorDServicoSuporte suporteP = new PrestadorDServicoSuporte(nome, enderecoEditado);
                                                    suporteP.FuncaoFuncionario();
                                                    suporteP.SalarioFuncionario();
                                                    suporteP.Cpf = cpf;
                                                    listaFuncionarios[i] = suporteP;
                                                    listaPrestadoresDServico[localizar] = suporteP;

                                                    index++;

                                                    Console.WriteLine("");
                                                }
                                            break;
                                            case 3:
                                                Console.WriteLine("");
                                                if (tipo == 1)
                                                {
                                                    PrestadorDServicoDiversos diversosP = new PrestadorDServicoDiversos(nome, enderecoEditado);
                                                    diversosP.FuncaoFuncionario();
                                                    diversosP.SalarioFuncionario();
                                                    diversosP.Cpf = cpf;
                                                    listaFuncionarios[i] = diversosP;
                                                    listaPrestadoresDServico[localizar] = diversosP;

                                
                                                    index++;

                                                    Console.WriteLine("");
                                                }

                                            break;
                                            default:
                                                Console.WriteLine("3RR0R: Opção Inválida!");
                                                Console.WriteLine("");

                                            break;
                                        }
                                   }
                                }
                            }
                        } else if (opt == 2)
                        {
                            //Solicitando o CNPJ para editar
                            do {
                                Console.Write("Digite o CNPJ do Funcionário que você deseja editar: ");
                                cnpj = Console.ReadLine();
                                ValCNPJ(cnpj);
                            } while (ValCNPJ(cnpj) == false);
                            editarNome = false;
                            editarCnpj = false;
                            editarEndereco = false;
                            bool jaCadastrado = false;
                            for (int i = 0; i < listaFuncionarios.Count; i++)
                            {
                                if (listaFuncionarios[i].Cnpj == cnpj)
                                {
                                    jaCadastrado = true;
                                }
                                if (i == listaFuncionarios.Count-1 && jaCadastrado == false) 
                                {
                                    Console.WriteLine("Funcionário não cadastrado");
                                }
                            }
                            for (int i = 0; i < listaFuncionarios.Count; i++)
                            {
                                int localizar = 0;
                                for (int j = 0; j < listaPrestadoresDServico.Count; j++)
                                {
                                    if (cnpj == listaPrestadoresDServico[j].Cnpj)
                                    {
                                        localizar = j;
                                    }
                                }
                                if (cnpj == listaFuncionarios[i].Cnpj)
                                {
                                    Console.WriteLine("Funcionário Localizado!");
                                    Console.WriteLine("Deseja editar o CNPJ do Funcionário? S/N");
                                    ler = Console.ReadLine();
                                    if (ler.ToLower() == "s")
                                   {
                                        editarCnpj = true;
                                        bool repetido = false;
                                        do
                                        {
                                            repetido = false;
                                            try
                                            {
                                                do {
                                                    Console.Write("Digite o novo CNPJ do Funcionário: ");
                                                    cnpj = Console.ReadLine();
                                                } while (ValCNPJ(cnpj) == false);
                                                foreach (Funcionario funcionario in listaFuncionarios)
                                                {
                                                    if (funcionario.Cnpj.Equals(cnpj))
                                                    {
                                                        repetido = true;
                                                        throw new ArgumentException("CNPJ já cadastrado");
                                                    }
                                                }
                                            } catch (ArgumentException e)
                                            {
                                                Console.WriteLine(e.Message);
                                            }
                                        } while (repetido == true);
                                   }
                                   Console.WriteLine("Deseja editar o Nome do Funcionário? S/N");
                                   ler = Console.ReadLine();
                                   if (ler.ToLower() == "s")
                                   {
                                        editarNome = true;
                                        Console.Write("Informe o Novo Nome do Funcionário: ");
                                        nome = Console.ReadLine();
                                        listaFuncionarios[i].Nome = nome;
                                        listaEmpregados[localizar].Nome = nome;
                                   }
                                   Console.WriteLine("Deseja editar o Endereço do Funcionário? S/N");
                                   ler = Console.ReadLine();
                                   if (ler.ToLower() == "s")
                                   {
                                        editarEndereco = true;
                                        //Solicitando as Novas Informações de Endereço

                                        //Rua
                                        Console.Write("Digite a Rua do Funcionário: ");
                                        rua = Console.ReadLine();
                                        listaPrestadoresDServico[localizar].Endereco.Rua = rua;

                                        //Número da Residência
                                        Console.Write("Digite o Número da Residência do Funcionário: ");
                                        numero = Int32.Parse(Console.ReadLine());
                                        listaPrestadoresDServico[localizar].Endereco.Numero = $"{numero}";

                                        //Bairro
                                        Console.Write("Digite o Bairro do Funcionário: ");
                                        bairro = Console.ReadLine();
                                        listaPrestadoresDServico[localizar].Endereco.Bairro = bairro;

                                        //Cidade
                                        Console.Write("Digite a Cidade do Funcionário: ");
                                        cidade = Console.ReadLine();
                                        listaPrestadoresDServico[localizar].Endereco.Cidade = cidade;

                                        //Estado
                                        Console.Write("Digite o Estado do Funcionário: ");
                                        estado = Console.ReadLine();
                                        listaPrestadoresDServico[localizar].Endereco.Estado = estado;

                                        
                                   }
                                   Console.WriteLine("Deseja editar o Cargo do Funcionário? S/N");
                                   ler = Console.ReadLine();
                                   if (ler.ToLower() == "s")
                                   {
                                        Console.WriteLine("Digite o número do Novo Cargo do Funcionário: 1-Programador, 2-Suporte, 3-Diversos");
                                        opcaoCargo = Int32.Parse(Console.ReadLine());
                                        if (editarCnpj == false)
                                        {
                                            cnpj = listaFuncionarios[i].Cnpj;
                                        }
                                        if (editarNome == false)
                                        {
                                            nome = listaFuncionarios[i].Nome;
                                        }
                                        if (editarEndereco == false)
                                        {
                                            enderecoEditado = listaFuncionarios[i].Endereco;
                                        } else
                                        {
                                            enderecoEditado = listaPrestadoresDServico[localizar].Endereco;
                                        }
                                        switch(opcaoCargo)
                                        {
                                            case 1:
                                                if (tipo == 1)
                                                {    
                                                    PrestadorDServicoProgramador programadorP = new PrestadorDServicoProgramador(nome, enderecoEditado);
                                                    programadorP.FuncaoFuncionario();
                                                    programadorP.SalarioFuncionario();
                                                    programadorP.Cnpj = cnpj;
                                                    listaFuncionarios[i] = programadorP;
                                                    listaPrestadoresDServico[localizar] = programadorP;

                                                    index++;

                                                    Console.WriteLine("");
                                                }

                                            break;
                                            case 2:

                                                Console.WriteLine("");
                                                if (tipo == 1)
                                                {
                                                    PrestadorDServicoSuporte suporteP = new PrestadorDServicoSuporte(nome, enderecoEditado);
                                                    suporteP.FuncaoFuncionario();
                                                    suporteP.SalarioFuncionario();
                                                    suporteP.Cnpj = cnpj;
                                                    listaFuncionarios[i] = suporteP;
                                                    listaPrestadoresDServico[localizar] = suporteP;

                                                    index++;

                                                    Console.WriteLine("");
                                                }
                                            break;
                                            case 3:
                                                Console.WriteLine("");
                                                if (tipo == 1)
                                                {
                                                    PrestadorDServicoDiversos diversosP = new PrestadorDServicoDiversos(nome, enderecoEditado);
                                                    diversosP.FuncaoFuncionario();
                                                    diversosP.SalarioFuncionario();
                                                    diversosP.Cnpj = cnpj;
                                                    listaFuncionarios[i] = diversosP;
                                                    listaPrestadoresDServico[localizar] = diversosP;

                                
                                                    index++;

                                                    Console.WriteLine("");
                                                }

                                            break;
                                            default:
                                                Console.WriteLine("3RR0R: Opção Inválida!");
                                                Console.WriteLine("");

                                            break;
                                        }
                                   }
                                }
                            }
                        }
                    }
                break;
                case 3:
                    if (tipo == 1)
                    {
                        Console.WriteLine("========== Lista ==========");
                        for (int i = 0; i < listaEmpregados.Count; i++)
                        {
                            cpf = listaEmpregados[i].Cpf;
                            Console.WriteLine($"CPF: {cpf[0]}{cpf[1]}{cpf[2]}.{cpf[3]}{cpf[4]}{cpf[5]}.{cpf[6]}{cpf[7]}{cpf[8]}-{cpf[9]}{cpf[10]}");
                            Console.WriteLine($"Nome: {listaEmpregados[i].Nome}");
                            Console.WriteLine($"Função: {listaEmpregados[i].Funcao}");
                            Console.WriteLine($"Salário: R$ {listaEmpregados[i].Salario}");
                            Console.WriteLine("---------- Endereço ----------");
                            Console.WriteLine($"Rua: {listaEmpregados[i].Endereco.Rua}");
                            Console.WriteLine($"Número Residência: {listaEmpregados[i].Endereco.Numero}");
                            Console.WriteLine($"Bairro: {listaEmpregados[i].Endereco.Bairro}");
                            Console.WriteLine($"Cidade: {listaEmpregados[i].Endereco.Cidade}");
                            Console.WriteLine($"Estado: {listaEmpregados[i].Endereco.Estado}");
                            Console.WriteLine("==============================");
                        }
                    } else if (tipo == 2)
                    {
                        Console.WriteLine("========== Lista ==========");
                        for (int i = 0; i < listaPrestadoresDServico.Count; i++)
                        {
                            cpf = listaPrestadoresDServico[i].Cpf;
                            cnpj = listaPrestadoresDServico[i].Cnpj;
                            if (cnpj.Length == 0 )
                            {
                                Console.WriteLine($"CPF: {cpf[0]}{cpf[1]}{cpf[2]}.{cpf[3]}{cpf[4]}{cpf[5]}.{cpf[6]}{cpf[7]}{cpf[8]}-{cpf[9]}{cpf[10]}");
                            } else if (cpf.Length == 0)
                            {
                                Console.WriteLine($"CNPJ: {cnpj[0]}{cnpj[1]}.{cnpj[2]}{cnpj[3]}{cnpj[4]}.{cnpj[5]}{cnpj[6]}{cnpj[7]}/{cnpj[8]}{cnpj[9]}{cnpj[10]}{cnpj[11]}-{cnpj[12]}{cnpj[13]}");
                            }
                            Console.WriteLine($"Nome: {listaPrestadoresDServico[i].Nome}");
                            Console.WriteLine($"Função: {listaPrestadoresDServico[i].Funcao}");
                            Console.WriteLine($"Salário: R$ {listaPrestadoresDServico[i].Salario}");
                            Console.WriteLine("---------- Endereço ----------");
                            Console.WriteLine($"Rua: {listaPrestadoresDServico[i].Endereco.Rua}");
                            Console.WriteLine($"Número Residência: {listaPrestadoresDServico[i].Endereco.Numero}");
                            Console.WriteLine($"Bairro: {listaPrestadoresDServico[i].Endereco.Bairro}");
                            Console.WriteLine($"Cidade: {listaPrestadoresDServico[i].Endereco.Cidade}");
                            Console.WriteLine($"Estado: {listaPrestadoresDServico[i].Endereco.Estado}");
                            Console.WriteLine("==============================");
                        }
                    }
                break;
                case 4:
                    if (tipo == 1)
                    {
                        //Solicitando CPF para consultar

                        do {
                            Console.Write("Digite o CPF do Funcionário que você deseja consultar: ");
                            cpf = Console.ReadLine();
                            ValCPF(cpf);
                        } while (ValCPF(cpf) == false);
                        for (int i = 0; i < listaFuncionarios.Count; i++)
                        {
                            bool jaCadastrado = false;
                            if (listaFuncionarios[i].Cpf == cpf)
                            {
                                jaCadastrado = true;
                            } else if (i == listaFuncionarios.Count-1 && jaCadastrado == false)
                            {
                                Console.WriteLine("Funcionário não cadastrado");
                            }
                        }
                        foreach (Funcionario funcionario in listaFuncionarios)
                        {
                            if (funcionario.Cpf.Equals(cpf))
                            {
                                Console.WriteLine("========== Consulta ==========");
                                cpf = funcionario.Cpf;
                                Console.WriteLine($"CPF: {cpf[0]}{cpf[1]}{cpf[2]}.{cpf[3]}{cpf[4]}{cpf[5]}.{cpf[6]}{cpf[7]}{cpf[8]}-{cpf[9]}{cpf[10]}");
                                Console.WriteLine($"Nome: {funcionario.Nome}");
                                Console.WriteLine($"Função: {funcionario.Funcao}");
                                Console.WriteLine($"Salário: R$ {funcionario.Salario}");
                                Console.WriteLine("---------- Endereço ----------");
                                Console.WriteLine($"Rua: {funcionario.Endereco.Rua}");
                                Console.WriteLine($"Número Residência: {funcionario.Endereco.Numero}");
                                Console.WriteLine($"Bairro: {funcionario.Endereco.Bairro}");
                                Console.WriteLine($"Cidade: {funcionario.Endereco.Cidade}");
                                Console.WriteLine($"Estado: {funcionario.Endereco.Estado}");
                                Console.WriteLine("==============================");
                            }
                        }
                    } else if (tipo == 2)
                    {
                        Console.WriteLine("O Funcionário é: 1-Pessoa Física, 2-Pessoa Jurídica");
                        Console.WriteLine("Informe o número da opção desejada: ");
                        ler = Console.ReadLine();
                        opcao = Convert.ToInt32(ler);
                        if (opcao == 1)
                        {
                            //Solicitando CPF para consultar

                            do {
                                Console.Write("Digite o CPF do Funcionário que você deseja consultar: ");
                                cpf = Console.ReadLine();
                                ValCPF(cpf);
                            } while (ValCPF(cpf) == false);
                            for (int i = 0; i < listaFuncionarios.Count; i++)
                            {
                                bool jaCadastrado = false;
                                if (listaFuncionarios[i].Cpf == cpf)
                                {
                                    jaCadastrado = true;
                                } else if (i == listaFuncionarios.Count-1 && jaCadastrado == false)
                                {
                                    Console.WriteLine("Funcionário não cadastrado");
                                }
                            }
                            foreach (Funcionario funcionario in listaFuncionarios)
                            {
                                if (funcionario.Cpf.Equals(cpf))
                                {
                                    Console.WriteLine("========== Consulta ==========");
                                    cpf = funcionario.Cpf;
                                    Console.WriteLine($"CPF: {cpf[0]}{cpf[1]}{cpf[2]}.{cpf[3]}{cpf[4]}{cpf[5]}.{cpf[6]}{cpf[7]}{cpf[8]}-{cpf[9]}{cpf[10]}");
                                    Console.WriteLine($"Nome: {funcionario.Nome}");
                                    Console.WriteLine($"Função: {funcionario.Funcao}");
                                    Console.WriteLine($"Salário: R$ {funcionario.Salario}");
                                    Console.WriteLine("---------- ENDEREÇO ----------");
                                    Console.WriteLine($"Rua: {funcionario.Endereco.Rua}");
                                    Console.WriteLine($"Número Residência: {funcionario.Endereco.Numero}");
                                    Console.WriteLine($"Bairro: {funcionario.Endereco.Bairro}");
                                    Console.WriteLine($"Cidade: {funcionario.Endereco.Cidade}");
                                    Console.WriteLine($"Estado: {funcionario.Endereco.Estado}");
                                    Console.WriteLine("==============================");
                                }
                            }
                        } else if (opcao == 2)
                        {
                            //Solicitando CNPJ para consultar

                            do {
                                Console.Write("Digite o CNPJ do Funcionário que você deseja consultar: ");
                                cnpj = Console.ReadLine();
                            } while (ValCNPJ(cnpj) == false);
                            for (int i = 0; i < listaFuncionarios.Count; i++)
                            {
                                bool jaCadastrado = false;
                                if (listaFuncionarios[i].Cnpj == cnpj)
                                {
                                    jaCadastrado = true;
                                } else if (i == listaFuncionarios.Count-1 && jaCadastrado == false)
                                {
                                    Console.WriteLine("Funcionário não cadastrado");
                                }
                            }
                            foreach (Funcionario funcionario in listaFuncionarios)
                            {
                                if (funcionario.Cnpj.Equals(cnpj))
                                {
                                    Console.WriteLine("========== Consulta ==========");
                                    cnpj = funcionario.Cnpj;
                                    Console.WriteLine($"CNPJ: {cnpj[0]}{cnpj[1]}.{cnpj[2]}{cnpj[3]}{cnpj[4]}.{cnpj[5]}{cnpj[6]}{cnpj[7]}/{cnpj[8]}{cnpj[9]}{cnpj[10]}{cnpj[11]}-{cnpj[12]}{cnpj[13]}");
                                    Console.WriteLine($"Nome: {funcionario.Nome}");
                                    Console.WriteLine($"Função: {funcionario.Funcao}");
                                    Console.WriteLine($"Salário: R$ {funcionario.Salario}");
                                    Console.WriteLine("---------- ENDEREÇO ----------");
                                    Console.WriteLine($"Rua: {funcionario.Endereco.Rua}");
                                    Console.WriteLine($"Número Residência: {funcionario.Endereco.Numero}");
                                    Console.WriteLine($"Bairro: {funcionario.Endereco.Bairro}");
                                    Console.WriteLine($"Cidade: {funcionario.Endereco.Cidade}");
                                    Console.WriteLine($"Estado: {funcionario.Endereco.Estado}");
                                    Console.WriteLine("==============================");
                                }
                            }
                        }
                    }
                break;
                case 5:
                    if (tipo == 1)
                    {
                        //Excluindo Empregado
                        cpf = "";
                        do {
                            Console.Write("Digite o CPF do Funcionário que você deseja excluir: ");
                            cpf = Console.ReadLine();
                        } while (ValCPF(cpf) == false);
                        for (int i = 0; i < listaFuncionarios.Count; i++)
                        {
                            int localizar = 0;
                            if (listaFuncionarios[i].Cpf == cpf)
                            {
                                for (int j = 0; j < listaEmpregados.Count; j++)
                                {
                                    if (cpf == listaEmpregados[j].Cpf)
                                    {
                                        localizar = j;
                                    }
                                }
                                Console.WriteLine("Tem certeza que deseja excluir esse Empregado? S/N");
                                ler = Console.ReadLine();
                                if (ler.ToLower() == "s")
                                {
                                    listaEmpregados.RemoveAt(localizar);
                                    listaFuncionarios.RemoveAt(i);
                                }
                            }
                        }
                    } else if (tipo == 2)
                    {
                        Console.Write("O Funcionário é: 1-Pessoa Física, 2-Pessoa Jurídica");
                        Console.Write("Informe o número da opção desejada: ");
                        ler = Console.ReadLine();
                        opt = Convert.ToInt32(ler);
                        if (opt == 1)
                        {
                            //Excluindo Prestador de Serviço
                            cpf = "";
                            do {
                                Console.Write("Digite o CPF do Funcionário que você deseja excluir: ");
                                cpf = Console.ReadLine();
                            } while (ValCPF(cpf) == false);
                            for (int i = 0; i < listaFuncionarios.Count; i++)
                            {
                                int localizar = 0;
                                if (listaFuncionarios[i].Cpf == cpf)
                                {
                                    for (int j = 0; j < listaPrestadoresDServico.Count; j++)
                                    {
                                        if (cpf == listaPrestadoresDServico[j].Cpf)
                                        {
                                            localizar = j;
                                        }
                                    }
                                    Console.WriteLine("Tem certeza que deseja excluir esse Empregado? S/N");
                                    ler = Console.ReadLine();
                                    if (ler.ToLower() == "s")
                                    {
                                        listaPrestadoresDServico.RemoveAt(localizar);
                                        listaFuncionarios.RemoveAt(i);
                                    }
                                }
                            }
                        } else if (opt == 2)
                        {
                            //Excluindo Prestador de Serviço
                            cnpj = "";
                            do {
                                Console.Write("Digite o CNPJ do Funcionário que você deseja excluir: ");
                                cnpj = Console.ReadLine();
                            } while (ValCNPJ(cnpj) == false);
                            for (int i = 0; i < listaFuncionarios.Count; i++)
                            {
                                int localizar = 0;
                                if (listaFuncionarios[i].Cnpj == cnpj)
                                {
                                    for (int j = 0; j < listaPrestadoresDServico.Count; j++)
                                    {
                                        if (cnpj == listaPrestadoresDServico[j].Cnpj)
                                        {
                                            localizar = j;
                                        }
                                    }
                                    Console.WriteLine("Tem certeza que deseja excluir esse Empregado? S/N");
                                    ler = Console.ReadLine();
                                    if (ler.ToLower() == "s")
                                    {
                                        listaPrestadoresDServico.RemoveAt(localizar);
                                        listaFuncionarios.RemoveAt(i);
                                    }
                                }
                            }
                        }
                    }
                break;
                case 6:
                    Console.WriteLine("Voltando...");
                break;
                default:
                    Console.WriteLine("Opção Inválida");
                break;
            }

            } while (opcaoMenu != 6);
        }
    }
}
