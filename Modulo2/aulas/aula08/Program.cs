using System;

namespace aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta()
            {
                Agencia = 1,
                Numero = 1,
                Correntista = "Hermine"
            };
            Conta conta2 = new Conta()
            {
                Agencia = 2,
                Numero = 2,
                Correntista = "Mendingo"
            };
            CrudConta crud = new CrudConta();
            crud.Adicionar(conta);
            crud.Adicionar(conta2);
            foreach (var item in crud.ListarContas())
            {
                Console.WriteLine($"{item.Agencia}, {item.Numero}, {item.Correntista}");
            }
            conta.Correntista = "Amélia";
            crud.Editar(conta);
            foreach (var item in crud.ListarContas())
            {
                Console.WriteLine($"{item.Agencia}, {item.Numero}, {item.Correntista}");
            }
            Conta consultar = crud.Consultar(2,3);
            if (consultar == null)
            {
                Console.WriteLine("Conta não encontrada!");
            }
            else
            {
                Console.WriteLine($"{consultar.Agencia}, {consultar.Numero}, {consultar.Correntista}");
            }
            crud.Excluir(1,1);
            crud.Excluir(1,3);
            foreach (var item in crud.ListarContas())
            {
                Console.WriteLine($"{item.Agencia}, {item.Numero}, {item.Correntista}");
            }
        }
    }
}
