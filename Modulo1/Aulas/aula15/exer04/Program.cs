using System;

namespace exer04
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            double salariominimo = 1302.00;
            Console.WriteLine("Gostaria de calcular o Imposto de Renda de um funcionário? Sim/Não");
            string ler = Console.ReadLine();
            if (ler.ToLower() == "sim")
            {
                Console.Write("Informe o nome do funcionário: ");
                nome = Console.ReadLine();
                Console.WriteLine("Qual o cargo do funcionário?");
                Console.WriteLine("1-Gerente");
                Console.WriteLine("2-Diretor");
                Console.WriteLine("3-Diversos");
                Console.Write("Informe a opção desejada: ");
                ler = Console.ReadLine();
                int opt = Convert.ToInt32(ler);
                switch (opt)
                {
                    case 1:
                        var gerente = new Funcionario();
                        gerente.Nome = nome;
                        gerente.Cargo = "Gerente";
                        gerente.Salario = salariominimo*5;
                        Console.WriteLine("=======================================");
                        Console.WriteLine("    Imposto de Renda do Funcionário    ");
                        Console.WriteLine("=======================================");
                        Console.WriteLine($"Nome: {gerente.Nome}");
                        Console.WriteLine($"Cargo: {gerente.Cargo}");
                        Console.WriteLine($"Salario: R$ {gerente.Salario}");
                        Console.WriteLine($"Imposto de Renda: R$ {gerente.ImpostoDeRenda(gerente.Salario)}");
                        Console.WriteLine("=======================================");
                    break;
                    case 2:
                        var diretor = new Funcionario();
                        diretor.Nome = nome;
                        diretor.Cargo = "Diretor";
                        diretor.Salario = salariominimo*10;
                        Console.WriteLine("=======================================");
                        Console.WriteLine("    Imposto de Renda do Funcionário    ");
                        Console.WriteLine("=======================================");
                        Console.WriteLine($"Nome: {diretor.Nome}");
                        Console.WriteLine($"Cargo: {diretor.Cargo}");
                        Console.WriteLine($"Salario: R$ {diretor.Salario}");
                        Console.WriteLine($"Imposto de Renda: R$ {diretor.ImpostoDeRenda(diretor.Salario)}");
                        Console.WriteLine("=======================================");
                    break;
                    case 3:
                        var diversos = new Funcionario();
                        diversos.Nome = nome;
                        diversos.Cargo = "Diversos";
                        diversos.Salario = salariominimo;
                        Console.WriteLine("=======================================");
                        Console.WriteLine("    Imposto de Renda do Funcionário    ");
                        Console.WriteLine("=======================================");
                        Console.WriteLine($"Nome: {diversos.Nome}");
                        Console.WriteLine($"Cargo: {diversos.Cargo}");
                        Console.WriteLine($"Salario: R$ {diversos.Salario}");
                        Console.WriteLine($"Imposto de Renda: R$ {diversos.ImpostoDeRenda(diversos.Salario)}");
                        Console.WriteLine("=======================================");
                    break;
                    default:
                        Console.WriteLine("Opção inválida...");
                    break;
                }
            } else
            {
                Console.WriteLine("Ok...");
            }
        }
    }
}
