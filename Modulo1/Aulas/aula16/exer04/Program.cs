using System;

namespace exer04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja calcular o Imposto de Renda  de  um funcionário? Sim/Não");
            string ler = Console.ReadLine();
            while (ler.ToLower() == "sim")
            {
                Console.Write("Informe o nome do Funcionário: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual o Cargo do Funcionário? ");
                Console.WriteLine("1-Gerente");
                Console.WriteLine("2-Diretor");
                Console.WriteLine("3-Diversos");
                Console.Write("Informe o Número da opção que representa o Cargo do Funcionário: ");
                ler=Console.ReadLine();
                int opt = Convert.ToInt32(ler);
                switch (opt)
                {
                    case 1:
                        Funcionario gerente = new Gerente(nome);
                        gerente.DefinirCargo();
                        gerente.DefinirSalario();
                        gerente.CalculoIR();
                        gerente.ExibirInfosDoIR(gerente);
                    break;
                    case 2:
                        Funcionario diretor = new Diretor(nome);
                        diretor.DefinirCargo();
                        diretor.DefinirSalario();
                        diretor.CalculoIR();
                        diretor.ExibirInfosDoIR(diretor);
                    break;
                    case 3:
                        Funcionario diversos = new Diversos(nome);
                        diversos.DefinirCargo();
                        diversos.DefinirSalario();
                        diversos.CalculoIR();
                        diversos.ExibirInfosDoIR(diversos);
                    break;
                    default:
                        Console.WriteLine("A opção selecionada está indisponível...");
                    break;
                }
                Console.WriteLine("Deseja calcular o Imposto de Renda  de  um funcionário? Sim/Não");
                ler = Console.ReadLine();
            }
        }
    }
}
