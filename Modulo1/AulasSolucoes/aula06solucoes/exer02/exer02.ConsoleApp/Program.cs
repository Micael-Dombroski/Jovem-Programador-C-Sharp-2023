using System;
using System.Collections.Generic;
using exer02.Classes;

namespace exer02.ConsoleApp
{
    class Program
    {
        static List<Estabelecimento> estabelecimentos = new List<Estabelecimento>();
        static string ler;
        static int OptMenu1;
        static DateTime Data;
        static void Main(string[] args)
        {
            DateTime pegandoDataAtual = DateTime.Now;
            int anoAtual = pegandoDataAtual.Year;
            int mesAtual = pegandoDataAtual.Month;
            int diaAtual = pegandoDataAtual.Day;
            Data = new DateTime(anoAtual, mesAtual, diaAtual);  
            do
            {
                do
                {
                    Console.WriteLine("----------Menu Estabelecimentos----------");
                    Console.WriteLine("[1] Cadastrar Estabelecimento");
                    Console.WriteLine("[2] Consultar Estabelecimento");
                    Console.WriteLine("[3] Listar Estabelecimentos");
                    Console.WriteLine("[4] Excluir Estabelecimento");
                    Console.WriteLine("[5] Sair");
                    Console.WriteLine("-----------------------------------------\n");
                    Console.Write("Insira o Número da Opção desejada: ");
                    ler = Console.ReadLine();
                } while (ENumero(ler) == false);
                OptMenu1 = Convert.ToInt32(ler);
                switch (OptMenu1)
                {
                    case 1:
                        Console.Write("Informe o Nome do Estabelecimento: ");
                        string nomeEstabelecimento = Console.ReadLine();
                        nomeEstabelecimento = nomeEstabelecimento.ToLower();
                        Console.Write("Informe o Nome do Gerente do Estabelecimento: ");
                        string nomeGerente = Console.ReadLine();
                        Estabelecimento estabelecimento = new Estabelecimento(nomeEstabelecimento, nomeGerente);
                        estabelecimentos.Add(estabelecimento);
                        break;
                    case 2:
                        bool Cadastrado = false;
                        Console.Write("Informe o Nome do Estabelecimento que deseja Consultar: ");
                        nomeEstabelecimento = Console.ReadLine();
                        nomeEstabelecimento = nomeEstabelecimento.ToLower();
                        foreach (var item in estabelecimentos)
                        {
                            if (item.NomeEstabelecimento == nomeEstabelecimento)
                            {
                                Cadastrado = true;
                                MenuProduto(item);
                            }
                        }
                        if (Cadastrado == false)
                        {
                            Console.WriteLine("Estabelecimento não Cadastrado");
                        }
                        
                        break;
                    case 3:
                        if (estabelecimentos.Count > 0)
                        {
                            Console.WriteLine("---------Lista de Estabelecimentos---------");
                            Console.WriteLine("Estabelecimento    | Gerente");
                            foreach (var item in estabelecimentos)
                            {
                                Console.WriteLine($"{item.NomeEstabelecimento} | {item.NomeGerente}");
                            }
                            Console.WriteLine("-------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("Não há nenhum estabelecimento cadastrado!");
                        }
                        break;
                    case 4:
                        Cadastrado = false;
                        Console.Write("Informe o Nome do Estabelecimento que deseja Excluir: ");
                        ler = Console.ReadLine();
                        foreach (var item in estabelecimentos)
                        {
                            if (item.NomeEstabelecimento == ler)
                            {
                                Cadastrado = true;
                                estabelecimentos.Remove(item);
                                break;
                            }
                        }
                        if (Cadastrado == true)
                        {
                            Console.WriteLine("Estabelecimento Excluído");
                        }
                        else
                        {
                            Console.WriteLine("Estabelecimento Não Cadastrado");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            } while (OptMenu1 != 5);
        }
        static bool ENumero (string palavra)
        {
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] > 57 || palavra[i] < 48)
                {
                    Console.WriteLine("Use apenas números nesse campo");
                    return false;
                }
            }
            return true;
        }
        static bool EDinheiro (string palavra)
        {
            int contarVirgula = 0;
            for (int i = 0; i < palavra.Length; i++)
            {
                if ((palavra[i] > 57 || palavra[i] < 48) && palavra[i] != 44)
                {
                    Console.WriteLine("Use apenas números nesse campo");
                    return false;
                } else if (palavra[i] == 44)
                {
                    contarVirgula++;
                    if (contarVirgula > 1)
                    {
                        Console.WriteLine("Não use mais de uma vírgula para esse valor");
                        return false;
                    } else if (i+2 != palavra.Length-1)
                    {
                        Console.WriteLine("O número só pode ter 2 casas decimais após a vírgula");
                        return false;
                    }
                }
            }
            double valor = Convert.ToDouble(palavra);
            if (valor <= 0.00)
            {
                Console.WriteLine("O Preço do Produto Não Poder ser R$ 0,00 ou inferior");
                return false;
            }
            return true;
        }
        static void MenuProduto(Estabelecimento estabelecimento)
        {
            do
            {
                do
                {
                    Console.WriteLine("----------Menu Produto----------");
                    Console.WriteLine("[1] Cadastrar Produto");
                    Console.WriteLine("[2] Editar Produto");
                    Console.WriteLine("[3] Consultar Produto");
                    Console.WriteLine("[4] Listar Produtos");
                    Console.WriteLine("[5] Excluir Produto");
                    Console.WriteLine("[6] Sair");
                    Console.WriteLine("--------------------------------\n");
                    Console.Write("Insira o Número da Opção desejada: ");
                    ler = Console.ReadLine();
                } while (ENumero(ler) == false);
                OptMenu1 = Convert.ToInt32(ler);
                switch (OptMenu1)
                {
                    case 1:
                        do
                        {
                            Console.Write("Informe o Codigo do Produto: ");
                            ler = Console.ReadLine();
                        } while (ENumero(ler) == false);
                        string codigoProduto = ler;
                        Console.Write("Informe o Nome do Produto: ");
                        string nomeProduto = Console.ReadLine();
                        do
                        {
                            Console.Write("Informe o Preço do Produto: ");
                            ler = Console.ReadLine();
                        } while (EDinheiro(ler) == false);
                        double precoProduto = Convert.ToDouble(ler);
                        do
                        {
                            Console.Write("Informe a Quantidade do Produto: ");
                            ler = Console.ReadLine();
                        } while (ENumero(ler) == false);
                        int quantidadeProduto = Convert.ToInt32(ler);
                        DateTime validadeProduto;
                        do
                        {
                            int data;
                            do
                            {
                                do
                                {
                                    Console.Write("Informe o último dia de validade do Produto: ");
                                    ler = Console.ReadLine();
                                    data = 0;
                                } while (ENumero(ler) == false);
                                data = Convert.ToInt32(ler);
                            } while (data <= 0 || data > 31);
                            int dia = Convert.ToInt32(ler);
                            do
                            {
                                do
                                {
                                    Console.Write("Informe o último mês de validade do Produto: ");
                                    ler = Console.ReadLine();
                                    data = 0;
                                } while (ENumero(ler) == false);
                                data = Convert.ToInt32(ler);
                            } while (data <= 0 || data > 12);
                            int mes = Convert.ToInt32(ler);
                            do
                            {
                                do
                                {
                                    Console.Write("Informe o último ano de validade do Produto: ");
                                    ler = Console.ReadLine();
                                    data = 0;
                                } while (ENumero(ler) == false);
                                data = Convert.ToInt32(ler);
                            } while (data < Data.Year);
                            int ano = Convert.ToInt32(ler);
                            validadeProduto = new DateTime(ano,mes,dia);
                            if (validadeProduto <= Data)
                            {
                                Console.WriteLine("Você Não Pode Cadastrar um Produto Vencido");
                            }
                        } while (validadeProduto <= Data);
                        Produto produtoCadastrar = new Produto(codigoProduto, nomeProduto, precoProduto, quantidadeProduto, validadeProduto);
                        estabelecimento.ProdutosCadastrados.Cadastrar(produtoCadastrar);
                        break;
                    case 2:
                        Console.Write("Informe o Código do Produto que deseja Editar: ");
                        codigoProduto = Console.ReadLine();
                        if (estabelecimento.ProdutosCadastrados.ConsultarCodigo(codigoProduto) == null)
                        {
                            Console.WriteLine("Produto Não Cadastrado");
                        }
                        else
                        {
                            Produto produtoEditar = estabelecimento.ProdutosCadastrados.ConsultarCodigo(codigoProduto);
                            Console.Write("Deseja Editar o Preço do Produto? S/N");
                            ler = Console.ReadLine();
                            if (ler.ToLower() == "s")
                            {
                                do
                                {
                                    Console.Write("Informe o Preço do Produto: ");
                                    ler = Console.ReadLine();
                                } while (EDinheiro(ler) == false);
                                precoProduto = Convert.ToDouble(ler);
                                produtoEditar.Preco = precoProduto;
                            }
                            Console.Write("Deseja Editar a Quatidade desse Produto? S/N");
                            ler = Console.ReadLine();
                            if (ler.ToLower() == "s")
                            {
                                quantidadeProduto = 0;
                                do
                                {
                                    do
                                    {
                                        Console.Write("Informe a Quantidade do Produto: ");
                                        ler = Console.ReadLine();
                                        quantidadeProduto = 0;
                                    } while (ENumero(ler) == false);
                                    quantidadeProduto = Convert.ToInt32(ler);
                                    if (quantidadeProduto < 0)
                                    {
                                        Console.WriteLine("A Quantidade de Produtos não pode ser menor que Zero");
                                    }
                                } while (quantidadeProduto < 0);
                                produtoEditar.Unidade = quantidadeProduto;
                            }
                            estabelecimento.ProdutosCadastrados.Editar(produtoEditar);
                        }
                        break;
                    case 3:
                        bool Cadastrado = false;
                        Console.Write("Informe o Código do Produto que deseja Consultar: ");
                        codigoProduto = Console.ReadLine();
                        if (estabelecimento.ProdutosCadastrados.ConsultarCodigo(codigoProduto) == null)
                        {
                            Console.WriteLine("Produto Não Cadastrado");
                        }
                        else
                        {
                            Produto produtoConsultar = estabelecimento.ProdutosCadastrados.ConsultarCodigo(codigoProduto);
                            DateTime validade = produtoConsultar.Validade;
                            Console.WriteLine("--------Dados do Produto--------");
                            Console.WriteLine($"Código: {produtoConsultar.Codigo}");
                            Console.WriteLine($"Nome: {produtoConsultar.Nome}");
                            Console.WriteLine($"Preço: R$ {produtoConsultar.Preco}");
                            Console.WriteLine($"Unidade: {produtoConsultar.Unidade}");
                            Console.WriteLine($"Validade: {validade.Day}/{validade.Month}/{validade.Year}");
                            Console.WriteLine("--------------------------------");
                        }
                        break;
                    case 4:
                        if (estabelecimento.ProdutosCadastrados.ConsultarTodos().Count > 0)
                        {
                            Console.WriteLine("---------Lista de Produtos---------");
                            Console.WriteLine("Código | Nome | Preço (R$) | Unidade | Validade ");
                            foreach (KeyValuePair<string,  Produto> par in estabelecimento.ProdutosCadastrados.ConsultarTodos())
                            {
                                DateTime validade = par.Value.Validade;
                                Console.Write($"{par.Value.Codigo} | ");
                                Console.Write($"{par.Value.Nome} | ");
                                Console.Write($"{par.Value.Preco} | ");
                                Console.Write($"{par.Value.Unidade} | ");
                                Console.WriteLine($"{validade.Day}/{validade.Month}/{validade.Year}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há nenhum produto cadastrado!");
                        }
                        break;
                    case 5:
                        Console.Write("Informe o Código do Produto que deseja Excluir: ");
                        string produtoExcluir = Console.ReadLine();
                        estabelecimento.ProdutosCadastrados.Excluir(produtoExcluir);
                        break;
                    case 6:
                        Console.WriteLine("Voltando...");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            } while (OptMenu1 != 6);
        }
    }
}
