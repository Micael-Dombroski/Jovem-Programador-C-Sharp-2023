using System;
using System.Collections.Generic;
using exer04.Classes;

namespace exer04.ConsoleApp
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
                        try
                        {
                            Console.Write("Informe o Nome do Estabelecimento: ");
                            string nomeEstabelecimento = Console.ReadLine();
                            nomeEstabelecimento = nomeEstabelecimento.ToLower();
                            foreach (var item in estabelecimentos)
                            {
                                if (item.NomeEstabelecimento == nomeEstabelecimento)
                                {
                                    throw new ArgumentException("Estabelecimento já cadastrado!");
                                    break;
                                }
                            }
                            Console.Write("Informe o Nome do Gerente do Estabelecimento: ");
                            string nomeGerente = Console.ReadLine();
                            nomeGerente = nomeGerente.ToLower();
                            Estabelecimento estabelecimento = new Estabelecimento(nomeEstabelecimento, nomeGerente);
                            estabelecimentos.Add(estabelecimento);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 2:
                        bool Cadastrado = false;
                        try
                        {
                            Console.Write("Informe o Nome do Estabelecimento que deseja Consultar: ");
                            string nomeEstabelecimento = Console.ReadLine();
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
                                throw new ArgumentOutOfRangeException("Estabelecimento Não Cadastrado");
                            }
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                            
                        
                        break;
                    case 3:
                        try
                        {
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
                                throw new ArgumentNullException("Não há nenhum estabelecimento cadastrado!");
                            }
                        }
                        catch (ArgumentNullException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                            
                        break;
                    case 4:
                        Cadastrado = false;
                        try
                        {
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
                                throw new ArgumentOutOfRangeException("Estabelecimento Não Cadastrado");
                            }
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            Console.WriteLine(e.Message);
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
            try
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] > 57 || palavra[i] < 48)
                    {
                        throw new ArgumentException("Use apenas números nesse campo");
                    }
                }
            } catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
        static bool EDinheiro (string palavra)
        {
            int contarVirgula = 0;
            try
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    if ((palavra[i] > 57 || palavra[i] < 48) && palavra[i] != 44)
                    {
                        throw new ArgumentException("Use apenas números nesse campo");
                    } else if (palavra[i] == 44)
                    {
                        contarVirgula++;
                        if (contarVirgula > 1)
                        {
                            throw new ArgumentException("Não use mais de uma vírgula para esse valor");
                        } else if (i+2 != palavra.Length-1)
                        {
                            throw new ArgumentException("O número só pode ter 2 casas decimais após a vírgula");
                        }
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
                
            double valor = Convert.ToDouble(palavra);
            try
            {
                if (valor <= 0.00)
                {
                    throw new ArgumentException("O Preço do Produto Não Poder ser R$ 0,00 ou inferior");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
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
                        nomeProduto = nomeProduto.ToLower();
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
                        DateTime validadeProduto = new DateTime();
                        bool validadeCerta = false;
                        do
                        {
                            validadeCerta = false;
                            try
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
                                    if (data <= 0 || data > 31)
                                    {
                                        throw new ArgumentException("O Dia não pode ser menor que 0 ou maior que 31");
                                    }
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
                                    if (data <= 0 || data > 12)
                                    {
                                        throw new ArgumentException("O Dia não pode ser menor que 0 ou maior que 12");
                                    }
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
                                    if (data < Data.Year)
                                    {
                                        throw new ArgumentException("O Ano não pode ser menor que o Ano Atual");
                                    }
                                } while (data < Data.Year);
                                int ano = Convert.ToInt32(ler);
                                validadeProduto = new DateTime(ano,mes,dia);
                                if (validadeProduto <= Data)
                                {
                                    throw new ArgumentException("Você Não Pode Cadastrar um Produto Vencido");
                                }
                                else
                                {
                                    validadeCerta = true;
                                }
                            }
                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        } while (validadeCerta == false);
                        Produto produtoCadastrar = new Produto(codigoProduto, nomeProduto, precoProduto, quantidadeProduto, validadeProduto);
                        estabelecimento.ProdutosCadastrados.Cadastrar(produtoCadastrar);
                        break;
                    case 2:
                        try
                        {
                            Console.Write("Informe o Código do Produto que deseja Editar: ");
                            codigoProduto = Console.ReadLine();
                            if (estabelecimento.ProdutosCadastrados.ConsultarCodigo(codigoProduto) == null)
                            {
                                throw new ArgumentException("Produto Não Cadastrado");
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
                                            throw new ArgumentException("A Quantidade de Produtos não pode ser menor que Zero");
                                        }
                                    } while (quantidadeProduto < 0);
                                    produtoEditar.Unidade = quantidadeProduto;
                                }
                                estabelecimento.ProdutosCadastrados.Editar(produtoEditar);
                            }
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                            
                        break;
                    case 3:
                        bool Cadastrado = false;
                        try
                        {
                            Console.Write("Informe o Código do Produto que deseja Consultar: ");
                            codigoProduto = Console.ReadLine();
                            if (estabelecimento.ProdutosCadastrados.ConsultarCodigo(codigoProduto) == null)
                            {
                                throw new ArgumentOutOfRangeException("Produto Não Cadastrado");
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
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                            
                        break;
                    case 4:
                        try
                        {
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
                                throw new ArgumentNullException("Não há nenhum produto cadastrado!");
                            }
                        }
                        catch (ArgumentNullException e)
                        {
                            Console.WriteLine(e.Message);
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
