using System;

namespace exer03
{
    class Program
    {
        static Contatos [] contatos = new Contatos[3];
        static ContatoPessoal [] pessoal = new ContatoPessoal[3];
        static ContatoDeTrabalho [] trabalho = new ContatoDeTrabalho[3];
        static void Main(string[] args)
        {
            int icont = 0;
            int ipess = 0;
            int itb = 0;
            int opt = 0;
            string ler = "";
            while (opt != 4)
            {
                Console.WriteLine("Você quer adicionar: 1-contato pessoal, 2-contato de trabalho, 3-contato não categorizado, 4-Não quero adicionar mais contatos");
                ler = Console.ReadLine();
                opt = Convert.ToInt32(ler);
                switch(opt)
                {
                    case 1:
                        if (ipess < pessoal.Length)
                        {
                            var contatoPessoal = new ContatoPessoal();
                            Console.Write("Informe o Nome do contato: ");
                            contatoPessoal.Nome = Console.ReadLine();
                            Console.Write("Informe o Telefone desse contato: ");
                            ler = Console.ReadLine();
                            contatoPessoal.Telefone = Convert.ToInt32(ler);
                            Console.Write("Informe o Endereço desse contato: ");
                            contatoPessoal.Endereco = Console.ReadLine();
                            pessoal[ipess]=contatoPessoal;
                            ipess++;
                        } else
                        {
                            Console.WriteLine("Você tem o máximo de contatos pessoais permitido...");
                        }
                    break;
                    case 2:
                        if (itb < trabalho.Length)
                        {
                            var contatoDeTrabalho = new ContatoDeTrabalho();
                            Console.Write("Informe o Nome do contato: ");
                            contatoDeTrabalho.Nome = Console.ReadLine();
                            Console.Write("Informe o Telefone desse contato: ");
                            ler = Console.ReadLine();
                            contatoDeTrabalho.Telefone = Convert.ToInt32(ler);
                            Console.Write("Informe o Endereço desse contato: ");
                            contatoDeTrabalho.Endereco = Console.ReadLine();
                            trabalho[itb]=contatoDeTrabalho;
                            itb++;
                        } else
                        {
                            Console.WriteLine("Você tem o máximo de contatos de trabalho permitido...");
                        }
                    break;
                    case 3:
                        if (icont < contatos.Length)
                        {
                            var contato = new Contatos();
                            Console.Write("Informe o Nome do contato: ");
                            contato.Nome = Console.ReadLine();
                            Console.Write("Informe o Telefone desse contato: ");
                            ler = Console.ReadLine();
                            contato.Telefone = Convert.ToInt32(ler);
                            Console.Write("Informe o Endereço desse contato: ");
                            contato.Endereco = Console.ReadLine();
                            contatos[icont]=contato;
                            icont++;
                        } else
                        {
                            Console.WriteLine("Você tem o máximo de contatos não categorizados permitido...");
                        }
                    break;
                    case 4:
                        Console.WriteLine("Ok...");
                    break;
                    default:
                        Console.WriteLine("Opção indisponível...");
                    break;
                }
            }
                Console.WriteLine("Você gostaria de ver seus contatos? Sim/Não");
                ler = Console.ReadLine();
                if (ler.ToLower() == "sim")
                {
                    Console.WriteLine("Você quer ver: 1-Contatos Pessoais, 2-Contatos de Trabalho, 3-Contatos Não Categorizados, 4-Todos os contatos");
                    ler = Console.ReadLine();
                    int resposta = Convert.ToInt32(ler);
                    switch (resposta)
                    {
                        case 1:
                            Console.WriteLine("===============================");
                            Console.WriteLine("=======Contatos Pessoais=======");
                            Console.WriteLine("===============================");
                            if (ipess == 0)
                            {
                                Console.WriteLine("Nenhum contato pessoal foi adicionado...");
                            } else 
                            {
                                for (int i = 0; i<= ipess; i++)
                                {
                                    Console.WriteLine($"Nome: {pessoal[i].Nome}");
                                    Console.WriteLine($"Telefone: {pessoal[i].Telefone}");
                                    Console.WriteLine($"Endereço: {pessoal[i].Endereco}");
                                    Console.WriteLine("===============================");
                                }
                            }
                        break;
                        case 2:
                            Console.WriteLine("================================");
                            Console.WriteLine("======Contatos de Trabalho======");
                            Console.WriteLine("================================");
                            if (itb == 0)
                            {
                                Console.WriteLine("Nenhum contato de trabalho foi adicionado...");
                            } else 
                            {
                                for (int i = 0; i<= itb; i++)
                                {
                                    Console.WriteLine($"Nome: {trabalho[i].Nome}");
                                    Console.WriteLine($"Telefone: {trabalho[i].Telefone}");
                                    Console.WriteLine($"Endereço: {trabalho[i].Endereco}");
                                    Console.WriteLine("================================");
                                }
                            }     
                        break;
                        case 3:
                            Console.WriteLine("==============================");
                            Console.WriteLine("==Contatos Não Categorizados==");
                            Console.WriteLine("==============================");
                            if (icont ==0)
                            {
                                Console.WriteLine("Nenhum contato não categorizado foi adicionado...");
                            } else 
                            {
                                for (int i = 0; i<= icont; i++)
                                {
                                    Console.WriteLine($"Nome: {contatos[i].Nome}");
                                    Console.WriteLine($"Telefone: {contatos[i].Telefone}");
                                    Console.WriteLine($"Endereço: {contatos[i].Endereco}");
                                    Console.WriteLine("==============================");
                                }
                            }       
                        break;
                        case 4:
                            Console.WriteLine("===============================");
                            Console.WriteLine("=======Lista de Contatos=======");
                            Console.WriteLine("===============================");
                            Console.WriteLine("=======Contatos Pessoais=======");
                            Console.WriteLine("===============================");
                            if (ipess == 0)
                            {
                                Console.WriteLine("Nenhum contato pessoal foi adicionado...");
                            } else 
                            {
                                for (int i = 0; i< ipess; i++)
                                {
                                    Console.WriteLine($"Nome: {pessoal[i].Nome}");
                                    Console.WriteLine($"Telefone: {pessoal[i].Telefone}");
                                    Console.WriteLine($"Endereço: {pessoal[i].Endereco}");
                                    Console.WriteLine("===============================");
                                }
                            }
                            Console.WriteLine("======Contatos de Trabalho======");
                            Console.WriteLine("================================");
                            if (itb == 0)
                            {
                                Console.WriteLine("Nenhum contato de trabalho foi adicionado...");
                            } else 
                            {
                                for (int i = 0; i< itb; i++)
                                {
                                    Console.WriteLine($"Nome: {trabalho[i].Nome}");
                                    Console.WriteLine($"Telefone: {trabalho[i].Telefone}");
                                    Console.WriteLine($"Endereço: {trabalho[i].Endereco}");
                                    Console.WriteLine("================================");
                                }
                            }
                            Console.WriteLine("==Contatos Não Categorizados==");
                            Console.WriteLine("==============================");
                            if (icont ==0)
                            {
                                Console.WriteLine("Nenhum contato não categorizado foi adicionado...");
                            } else 
                            {
                                for (int i = 0; i< icont; i++)
                                {
                                    Console.WriteLine($"Nome: {contatos[i].Nome}");
                                    Console.WriteLine($"Telefone: {contatos[i].Telefone}");
                                    Console.WriteLine($"Endereço: {contatos[i].Endereco}");
                                    Console.WriteLine("==============================");
                                }
                            }
                        break;
                        default:
                            Console.WriteLine("Opção indisponível...");
                        break;
                    }
                } else
                {
                    Console.WriteLine("Ok...");
                }
        }
    }
}
