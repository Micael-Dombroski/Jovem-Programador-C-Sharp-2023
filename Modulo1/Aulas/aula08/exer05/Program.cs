using System;

namespace exer05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IBGE");
                double salario = 0.0;
                double somasalarios = 0.0;
                double maiorsalario = 0.0;
                double menorsalario = 10000000.0;
                int abaixomeiosalario = 0;
                int npessoas = 0;
                int qtfilhos = 0;
                int nfilhos = 0;
                Console.WriteLine("Deseja cadastrar os daodos de uma pessoa no IBGE? S/N");
                var ler = Console.ReadLine();
                while (ler == "S" || ler == "s")
                {
                    npessoas++;
                    Console.WriteLine("Informe o salário da pessoa: ");
                    ler = Console.ReadLine();
                    salario = Convert.ToDouble(ler);
                    somasalarios += salario;
                    Console.WriteLine("Quantos filhos essa pessoa tem?");
                    ler = Console.ReadLine();
                    nfilhos = Convert.ToInt32(ler);
                    qtfilhos += nfilhos;
                    
                    if (maiorsalario < salario)
                    {
                        maiorsalario = salario;
                    }
                    if (menorsalario > salario)
                    {
                        menorsalario = salario;
                    }
                    if (salario <= 1818.0)
                    {
                        abaixomeiosalario++;
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Deseja cadastrar os daodos de outra pessoa no IBGE? S/N");
                    ler = Console.ReadLine();
                }
                Console.WriteLine("\n");
                double mediasalario = somasalarios/npessoas;
                double qtpessoas = Convert.ToDouble(npessoas);                
                Console.WriteLine("O número de pessoas registradas foi " + npessoas);
                Console.WriteLine("A média salarial é  R$ " + mediasalario);
                Console.WriteLine("A média de filhos é " + (qtfilhos/npessoas));
                Console.WriteLine("O maior salário informado foi R$ " + maiorsalario);
                Console.WriteLine("O menor salário informado foi R$ " + menorsalario);
                Console.WriteLine("A % de pessoas que recebem abaixo de 1.5 salários mínimos é " + (abaixomeiosalario/(qtpessoas/100)) + "%.");
        }
    }
}
