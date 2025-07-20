using System;
using System.Collections.Generic;
using exer02.Classes;

namespace exer02.ConsoleApp
{
    class Program
    {
        static CrudVeiculo veiculos = new CrudVeiculo(null,0,null);
        static string ler = "";
        static int optMenu = 0;
        static int opt= 0;
        static void Main(string[] args)
        {
            do
            {
                optMenu = 0;
                Console.WriteLine("--------------Pedágio--------------");
                Console.WriteLine("               Menu");
                Console.WriteLine("[1] Cadastrar Veiculo");
                Console.WriteLine("[2] Mostrar Informações do Veiculo Veiculo");
                Console.WriteLine("[3] Sair");
                Console.WriteLine("-----------------------------------\n");
                do
                {
                    Console.Write("Informe o número da opção desejada: ");
                    ler = Console.ReadLine();
                } while (ENumero(ler) == false);
                optMenu = Convert.ToInt32(ler);
                switch (optMenu)
                {
                    case 1:
                        do
                        {
                            opt = 0;
                            Console.WriteLine("Menu de Cadastros");
                            Console.WriteLine("[1] Cadastrar Carro");
                            Console.WriteLine("[2] Cadastrar Moto");
                            Console.WriteLine("[3] Cadastrar Caminhão");
                            Console.WriteLine("[4] Voltar");
                            do
                            {
                                Console.Write("Informe o número da opção desejada: ");
                                ler = Console.ReadLine();
                            } while (ENumero(ler) == false);
                            opt = Convert.ToInt32(ler);
                            switch (opt)
                            {
                                case 1:
                                    Console.Write("Informe a Placa do Carro: ");
                                    string placa = Console.ReadLine();
                                    if (veiculos.ConsultarPlaca(placa) == null)
                                    {
                                        int anoFabricacao = 0;
                                        do
                                        {
                                            do
                                            {
                                                Console.Write("Informe o Ano de Fabricação do Carro: ");
                                                ler = Console.ReadLine();
                                            } while (ENumero(ler) == false);
                                            anoFabricacao = Convert.ToInt32(ler);
                                        } while (anoFabricacao < 1886 || anoFabricacao > 2023);
                                        Console.Write("Informe o Modelo do Carro: ");
                                        string modelo = Console.ReadLine();
                                        do
                                        {
                                            Console.Write("Informe a Quantidade de Passageiros: ");
                                            ler = Console.ReadLine();
                                        } while (ENumero(ler) == false);
                                        int qtPassageiros = Convert.ToInt32(ler);
                                        Veiculos carro = new Carro(placa,anoFabricacao,modelo,qtPassageiros);
                                        carro.TipoVeiculo();
                                        veiculos.Cadastrar(carro);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Placa já cadastrada");
                                    }
                                break;
                                case 2:
                                    Console.Write("Informe a Placa da Moto: ");
                                    placa = Console.ReadLine();
                                    if (veiculos.ConsultarPlaca(placa) == null)
                                    {
                                        int anoFabricacao = 0;
                                        do
                                        {
                                            do
                                            {
                                                Console.Write("Informe o Ano de Fabricação da Moto: ");
                                                ler = Console.ReadLine();
                                            } while (ENumero(ler) == false);
                                            anoFabricacao = Convert.ToInt32(ler);
                                        } while (anoFabricacao < 1885 || anoFabricacao > 2023);
                                        Console.Write("Informe o Modelo da Moto: ");
                                        string modelo = Console.ReadLine();
                                        do
                                        {
                                            Console.Write("Informe a Quantidade de Cilindradas da Moto: ");
                                            ler = Console.ReadLine();
                                        } while (ENumero(ler) == false);
                                        int qtCilindradas = Convert.ToInt32(ler);
                                        Veiculos moto = new Moto(placa,anoFabricacao,modelo,qtCilindradas);
                                        moto.TipoVeiculo();
                                        veiculos.Cadastrar(moto);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Placa já cadastrada");
                                    } 
                                break;
                                case 3:
                                    Console.Write("Informe a Placa do Caminhão: ");
                                    placa = Console.ReadLine();
                                    if (veiculos.ConsultarPlaca(placa) == null)
                                    {
                                        int anoFabricacao = 0;
                                        do
                                        {
                                            do
                                            {
                                                Console.Write("Informe o Ano de Fabricação do Caminhão: ");
                                                ler = Console.ReadLine();
                                            } while (ENumero(ler) == false);
                                            anoFabricacao = Convert.ToInt32(ler);
                                        } while (anoFabricacao < 1896 || anoFabricacao > 2023);
                                        Console.Write("Informe o Modelo do Caminhão: ");
                                        string modelo = Console.ReadLine();
                                        do
                                        {
                                            Console.Write("Informe o Peso Total do Caminhão: ");
                                            ler = Console.ReadLine();
                                        } while (EDOUBLE(ler) == false);
                                        double peso = Convert.ToDouble(ler);
                                        do
                                        {
                                            Console.Write("Informe o Valor da Carga do Caminhão: R$ ");
                                            ler = Console.ReadLine();
                                        } while (EDOUBLE(ler) == false);
                                        double valorCarga = Convert.ToDouble(ler);
                                        Veiculos caminhao = new Caminhao(placa,anoFabricacao,modelo,peso,valorCarga);
                                        caminhao.TipoVeiculo();
                                        veiculos.Cadastrar(caminhao);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Placa já cadastrada");
                                    } 
                                break;
                                case 4:
                                    Console.WriteLine("Voltando...");
                                break;
                                default:
                                    Console.WriteLine("Opção Indisponível");
                                break;
                            }
                        } while (opt != 4);
                    break;
                    case 2:
                        Console.Write("Informe a Placa do Veículo que deseja Consultar: ");
                        ler = Console.ReadLine();
                        if (veiculos.ConsultarPlaca(ler) == null)
                        {
                            Console.WriteLine("Placa Não Cadastrada");
                        }
                        else
                        {
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("     Informação Do Veículo");
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine($"Placa: {ler}");
                            Veiculos veiculo = veiculos.ConsultarPlaca(ler);
                            if (veiculo.MostrarTipo()==1)
                            {
                                Console.WriteLine($"Tipo: Carro");
                                Carro carro = (Carro)veiculo;
                                Console.WriteLine($"Ano de Fabricação: {carro.AnoFabricacao}");
                                Console.WriteLine($"Idade do Veículo: {carro.IdadeDoVeiculo()} anos");
                                Console.WriteLine($"Modelo: {carro.Modelo}");
                                Console.WriteLine($"Quantidade de Passageiros: {carro.QtPassageiros}");
                                Console.WriteLine($"Pedágio: R$ {carro.Pedagio()}");

                            }
                            else if (veiculo.MostrarTipo()==2)
                            {
                                Console.WriteLine($"Tipo: Moto");
                                Moto moto = (Moto)veiculo;
                                Console.WriteLine($"Ano de Fabricação: {moto.AnoFabricacao}");
                                Console.WriteLine($"Idade do Veículo: {moto.IdadeDoVeiculo()} anos");
                                Console.WriteLine($"Modelo: {moto.Modelo}");
                                Console.WriteLine($"Quantidade de Cilindradas: {moto.QtCilindradas}");
                                Console.WriteLine($"Pedágio: R$ {moto.Pedagio()}");
                            }
                            else if (veiculo.MostrarTipo()==3)
                            {
                                Console.WriteLine($"Tipo: Caminhão");
                                Caminhao caminhao = (Caminhao)veiculo;
                                Console.WriteLine($"Ano de Fabricação: {caminhao.AnoFabricacao}");
                                Console.WriteLine($"Idade do Veículo: {caminhao.IdadeDoVeiculo()} anos");
                                Console.WriteLine($"Modelo: {caminhao.Modelo}");
                                Console.WriteLine($"Peso Total do Caminhão: {caminhao.PesoTotal}");
                                Console.WriteLine($"Valr da Carga do Caminhão: R$ {caminhao.ValorCarga}");
                                Console.WriteLine($"Pedágio: R$ {caminhao.Pedagio()}");
                            }
                            Console.WriteLine("-------------------------------\n");
                        }
                    break;
                    case 3:
                        Console.WriteLine("Saindo...");
                    break; 
                    default:
                        Console.WriteLine("Opção Indisponível");
                    break;
                }
            } while (optMenu != 3);
            
            
        }
        static bool ENumero (string palavra)
        {
            for (int i = opt; i < palavra.Length; i++)
            {
                if (palavra[i] > 57 || palavra[i] < 48)
                {
                    Console.WriteLine("Use apenas números nesse campo");
                    return false;
                }
            }
            return true;
        }
        static bool EDOUBLE (string palavra)
        {
            int contarVirgula = 0;
            for (int i = opt; i < palavra.Length; i++)
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
            return true;
        }
    }
}
