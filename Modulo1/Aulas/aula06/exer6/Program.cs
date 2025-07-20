using System;

namespace exer6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da nota fiscal: ");
            var ler = Console.ReadLine();
            double valorDaNotaFiscal = Convert.ToDouble(ler);
            Console.WriteLine("O valor da nota fiscal é: R$ " + valorDaNotaFiscal);
            double imposto = 0;
            if (valorDaNotaFiscal <= 999) 
            {
                imposto = valorDaNotaFiscal * 0.02;
            } else if (valorDaNotaFiscal <= 2999)
            {
                imposto = valorDaNotaFiscal * 0.025;
            } else if (valorDaNotaFiscal <= 6999)
            {
                imposto = valorDaNotaFiscal * 0.028;
            } else {
                imposto = valorDaNotaFiscal * 0.03;
            }
            Console.WriteLine("O valor de imposto que será pago é: R$ " + imposto);
        }
    }
}
