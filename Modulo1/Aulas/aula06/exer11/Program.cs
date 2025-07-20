using System;

namespace exer11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salário: ");
            var ler = Console.ReadLine();
            double salario = Convert.ToDouble(ler);
            double aumento = 0.0;
            double novosalario = 0.0;
            string pcaumento = "";
            if (salario <= 1280)
            {
                pcaumento = "20%";
                novosalario = salario + (salario * 0.2);
                aumento = novosalario - salario;
            } else if (salario <= 1700)
            {
                pcaumento = "15%";
                novosalario = salario + (salario * 0.15);
                aumento = novosalario - salario;
            } else if (salario <= 2500)
            {
                pcaumento = "10%";
                novosalario = salario + (salario * 0.1);
                aumento = novosalario - salario;
            } else
            {
                pcaumento = "5%";
                novosalario = salario + (salario * 0.05);
                aumento = novosalario - salario;
            }
            Console.WriteLine("Seus salário antes do reajusta era: R$ " + salario);
            Console.WriteLine("O percentual de aumento aplicado é de " + pcaumento);
            Console.WriteLine("O valor do aumento é: R$ " + aumento);
            Console.WriteLine("Seus salário após o reajuste é: R$ " + novosalario);
        }
    }
}
