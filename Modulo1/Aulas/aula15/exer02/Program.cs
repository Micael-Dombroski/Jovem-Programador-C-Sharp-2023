using System;

namespace exer02
{
    class Program
    {
        static void Main(string[] args)
        {
            var  funcionario = new Funcionario();
            funcionario.CPF= "111.111.111-11";
            funcionario.Nome="Lucas";
            funcionario.Salario=1500.00;
            var programador = new Programador();
            programador.CPF = "222.222.222-22";
            programador.Nome = "Jorge";
            programador.Salario = funcionario.Salario;
            var suporte = new Suporte();
            suporte.CPF = "333.333.333-33";
            suporte.Nome = "Luana";
            suporte.Salario = funcionario.Salario;
            Console.WriteLine("=============================================");
            Console.WriteLine("Folha de Pagamento");
            Console.WriteLine("=============================================");
            Console.WriteLine($"CPF: {funcionario.CPF}");
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine("Função: Funcionário Comum");
            Console.WriteLine($"Salário: R$ {funcionario.SalarioFun(funcionario.Salario)}");
            Console.WriteLine("=============================================");
            Console.WriteLine("=============================================");
            Console.WriteLine("Folha de Pagamento");
            Console.WriteLine("=============================================");
            Console.WriteLine($"CPF: {programador.CPF}");
            Console.WriteLine($"Nome: {programador.Nome}");
            Console.WriteLine("Função: Programador");
            Console.WriteLine($"Salário: R$ {programador.SalarioFun(programador.Salario)}");
            Console.WriteLine("=============================================");
            Console.WriteLine("=============================================");
            Console.WriteLine("Folha de Pagamento");
            Console.WriteLine("=============================================");
            Console.WriteLine($"CPF: {suporte.CPF}");
            Console.WriteLine($"Nome: {suporte.Nome}");
            Console.WriteLine("Função: Suporte");
            Console.WriteLine($"Salário: R$ {suporte.SalarioFun(suporte.Salario)}");
            Console.WriteLine("=============================================");
        }
    }
}
