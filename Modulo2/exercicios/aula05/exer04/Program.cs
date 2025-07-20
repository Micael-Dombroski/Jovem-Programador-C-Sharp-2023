using System;

namespace exer04
{
    class Program
    {
        static Cliente [] clientes = new Cliente[0];
        static Fornecedor [] fornecedores = new Fornecedor[0];
        static int opt;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("=========Menu=========");
                Console.WriteLine("[1] Fornecedor");
                Console.WriteLine("[2] Cliente");
                Console.WriteLine("[3] Sair");
                Console.WriteLine("======================");
                Console.WriteLine("Selecione o Menu que deseja acessar: ");
                opt = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opt)
                {
                    case 1:
                        MenuFornecedor();
                        opt = 0;
                        break;
                    case 2:
                        MenuCliente();
                        opt = 0;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (opt != 3);
            Console.WriteLine("\n==============================");
            Console.WriteLine("     Lista de Fornecedores    ");
            Console.WriteLine("==============================");
            foreach (var item in fornecedores)
            {
                Console.WriteLine($"ID: {item.MostrarID()}");
                Console.WriteLine($"Razão Social: {item.RazaoSocial}");
                Console.WriteLine($"Nome Fantasia: {item.NomeFantasia}");
                Console.WriteLine($"CNPJ: {item.CNPJ}");
                Console.WriteLine("==============================");
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n==============================");
            Console.WriteLine("      Lista de Clientes       ");
            Console.WriteLine("==============================");
            foreach (var item in clientes)
            {
                Console.WriteLine($"ID: {item.MostrarID()}");
                Console.WriteLine($"Razão Social: {item.RazaoSocial}");
                Console.WriteLine($"Nome Fantasia: {item.NomeFantasia}");
                Console.WriteLine($"CNPJ: {item.CNPJ}");
                Console.WriteLine($"Crédito Atual: R$ {item.SaldoAtual.ToString("F")}");
                Console.WriteLine($"Crédito Usado: R$ {item.SaldoGastado().ToString("F")}");
                Console.WriteLine("==============================");
            }
        }
        static void MenuFornecedor()
        {
            do
            {
                opt = 0;
                Console.WriteLine("====Menu de Fornecedores====");
                Console.WriteLine("[1] Cadastrar Fornecedor");
                Console.WriteLine("[2] Consultar Fornecedor");
                Console.WriteLine("[3] Voltar");
                Console.WriteLine("============================");
                Console.WriteLine("Selecione o Menu que deseja acessar: ");
                opt = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opt)
                {
                    case 1:
                        CadastrarFornecedor();
                        break;
                    case 2:
                        ConsultarFornecedor();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Voltando...");
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (opt != 3);
        }
        static void CadastrarFornecedor()
        {
            Console.Write("Informe a Razão Social do Fornecedor: ");
            string razaoSocial = Console.ReadLine();
            Console.Write("Informe o Nome Fantasia do Fornecedor: ");
            string nomeFantasia = Console.ReadLine();
            Console.Write("Informe o CNPJ do Fornecedor: ");
            string cnpj = Console.ReadLine();
            Fornecedor [] aumentar = new Fornecedor[fornecedores.Length+1];
            for (int i = 0; i < fornecedores.Length; i++)
            {
                aumentar[i] = fornecedores[i];
            }
            fornecedores = aumentar;
            fornecedores[fornecedores.Length-1] = new Fornecedor(razaoSocial, nomeFantasia, cnpj);
            Console.Clear();
            Console.WriteLine("Fornecedor Cadastrado com Sucesso, o fornecedor cadastrado recebeu o ID: " + fornecedores[fornecedores.Length-1].MostrarID());
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
        static void ConsultarFornecedor()
        {
            Console.WriteLine("Informe o ID do Fornecedor que deseja Consultar: ");
            int id = int.Parse(Console.ReadLine());
            int c = 0;
            foreach (var item in fornecedores)
            {
                if (item.MostrarID() == id)
                {
                    Console.Clear();
                    Console.WriteLine("==============================");
                    Console.WriteLine("   Informação do Fornecedor   ");
                    Console.WriteLine("==============================");
                    Console.WriteLine($"ID: {item.MostrarID()}");
                    Console.WriteLine($"Razão Social: {item.RazaoSocial}");
                    Console.WriteLine($"Nome Fantasia: {item.NomeFantasia}");
                    Console.WriteLine($"CNPJ: {item.CNPJ}");
                    Console.WriteLine("==============================");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (c == fornecedores.Length-1)
                {
                    Console.Clear();
                    Console.WriteLine("Fornecedor Não Cadastrado!");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    c++;
                }
            }
        }
        static void MenuCliente()
        {
            do
            {
                opt = 0;
                Console.WriteLine("====Menu de Clientes====");
                Console.WriteLine("[1] Cadastrar Cliente");
                Console.WriteLine("[2] Consultar Cliente");
                Console.WriteLine("[3] Voltar");
                Console.WriteLine("============================");
                Console.WriteLine("Selecione o Menu que deseja acessar: ");
                opt = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opt)
                {
                    case 1:
                        CadastrarCliente();
                        break;
                    case 2:
                        ConsultarCliente();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Voltando...");
                        break;
                    default:
                        Console.WriteLine("[3RR0R] Opção Inválida");
                        break;
                }
            } while (opt != 3);
        }
        static void CadastrarCliente()
        {
            Console.Write("Informe a Razão Social do Cliente: ");
            string razaoSocial = Console.ReadLine();
            Console.Write("Informe o Nome Fantasia do Cliente: ");
            string nomeFantasia = Console.ReadLine();
            Console.Write("Informe o CNPJ do Cliente: ");
            string cnpj = Console.ReadLine();
            Console.Write("Informe o Saldo de Crédito do Cliente: R$ ");
            double credito = double.Parse(Console.ReadLine());
            double saldoCredito = double.Parse(credito.ToString("F"));
            Cliente [] aumentar = new Cliente[clientes.Length+1];
            for (int i = 0; i < clientes.Length; i++)
            {
                aumentar[i] = clientes[i];
            }
            clientes = aumentar;
            clientes[clientes.Length-1] = new Cliente(razaoSocial, nomeFantasia, cnpj, saldoCredito);
            Console.Clear();
            Console.WriteLine("Cliente Cadastrado com Sucesso, o cliente cadastrado recebeu o ID: " + clientes[clientes.Length-1].MostrarID());
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
        static void ConsultarCliente()
        {
            Console.WriteLine("Informe o ID do Cliente que deseja Consultar: ");
            int id = int.Parse(Console.ReadLine());
            int c = 0;
            foreach (var item in clientes)
            {
                if (item.MostrarID() == id)
                {
                    Console.Clear();
                    bool GastarCredito = true;
                    do
                    {
                        Console.WriteLine("==============================");
                        Console.WriteLine("   Informação do Cliente   ");
                        Console.WriteLine("==============================");
                        Console.WriteLine($"ID: {item.MostrarID()}");
                        Console.WriteLine($"Razão Social: {item.RazaoSocial}");
                        Console.WriteLine($"Nome Fantasia: {item.NomeFantasia}");
                        Console.WriteLine($"CNPJ: {item.CNPJ}");
                        Console.WriteLine($"Crédito Atual: R$ {item.SaldoAtual.ToString("F")}");
                        Console.WriteLine($"Crédito Usado: R$ {item.SaldoGastado().ToString("F")}");
                        Console.WriteLine("==============================");
                        Console.WriteLine("Deseja Gastar seu Crédito S/N");
                        string ler = Console.ReadLine();
                        if (ler.ToLower() == "s")
                        {
                            Console.Write("Informe a quantidade de Crédito que deseja gastar: R$ ");
                            double gastar = double.Parse(Console.ReadLine());
                            gastar = double.Parse(gastar.ToString("F"));
                            if (item.GastarCredito(gastar) == false)
                            {
                                Console.WriteLine("Saldo Insuficiente...");
                                Console.WriteLine("Pressione qualquer tecla para voltar");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Crédito Usado Com Sucesso!");
                                Console.WriteLine("Pressione qualquer tecla para voltar");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            GastarCredito = false;
                        }
                        Console.Clear();
                    } while (GastarCredito != false);
                }
                else if (c == clientes.Length-1)
                {
                    Console.Clear();
                    Console.WriteLine("Cliente Não Cadastrado!");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    c++;
                }
            }
        }
    }
}
