using System;

namespace exer02
{
    class Program
    {
        public static Cliente [] Clientes = new Cliente [0];
        static void Main(string[] args)
        {
                string ler;
                int opt; 
            do
            {
                Console.WriteLine("Escolha uma das opções do nosso Menu!");
                Console.WriteLine("1-Cadastrar Cliente");
                Console.WriteLine("2-Listar Clientes");
                Console.WriteLine("3-Sair");
                Console.Write("Informe o número da opção desejada: ");
                ler = Console.ReadLine();
                opt = Convert.ToInt32(ler);
                switch (opt)
                {
                    case 1:
                        Console.Write("Informe o Nome do Cliente: ");
                        string nome = Console.ReadLine();
                        Console.Write("Informe a Idade do Cliente: ");
                        ler = Console.ReadLine();
                        int idade = Convert.ToInt32(ler);
                        while (idade < 18)
                        {
                            Console.WriteLine("3RR0R: O Cliente não pode ser menor de Idade...");
                            Console.Write("Informe a Idade do Cliente: ");
                            ler = Console.ReadLine();
                            idade = Convert.ToInt32(ler);
                        }
                        Console.WriteLine("Para concluir o cadastro vamos precisar de algumas informações sobre seu Endereço.");
                        Console.Write("Nome da Rua: ");
                        string rua = Console.ReadLine();
                        Console.Write("Nome do Bairro: ");
                        string bairro = Console.ReadLine();
                        Console.Write("Número da Casa: ");
                        ler = Console.ReadLine();
                        int numero = Convert.ToInt32(ler);
                        Console.Write("Nome da Cidade: ");
                        string cidade = Console.ReadLine();
                        Console.Write("Nome do Estado (ou Sigla): ");
                        string estado = Console.ReadLine();
                        Endereco endereco = new Endereco(rua,bairro,numero,cidade,estado);
                        Cliente cliente = new Cliente(nome, idade, endereco);
                        
                        Cliente [] tempClientes = new Cliente [Clientes.Length+1];
                        for (int i = 0; i < Clientes.Length; i++)
                        {
                            tempClientes[i] = Clientes[i];
                        }
                        Clientes = tempClientes;
                        Clientes[Clientes.Length-1] = cliente;
                    break;
                    case 2:
                        if (Clientes.Length < 1)
                        {
                            Console.WriteLine("A Lista de Clientes Precisa de Clientes para ser Exibida :)");
                        } else
                        {
                            Console.WriteLine("===================================================");
                            Console.WriteLine("                 Lista de Clientes                 ");
                            Console.WriteLine("===================================================");
                            for (int i = 0; i < Clientes.Length; i++)
                            {
                                Console.WriteLine($"{Clientes[i].Nome} - {Clientes[i].Endereco.Cidade} ({Clientes[i].Endereco.Estado})");
                            }
                            Console.WriteLine("===================================================");
                            Console.WriteLine("\n");
                        }   
                    break;
                    case 3:
                        Console.WriteLine("Saindo...");
                    break;
                    default:
                        Console.WriteLine("Opção Inválida...");
                    break;
                }
            } while (opt != 3);
                
        }
    }
}
