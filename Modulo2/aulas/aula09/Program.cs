using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aula09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Conta conta01 = new ContaCorrente(1,1);
            Conta conta02 = new ContaCorrente(1,2);
            Conta conta03 = new ContaCorrente(1,3);
            Conta conta04 = new ContaCorrente(1,4);

            HashSet<Conta> contas  = new HashSet<Conta>();
            contas.Add(conta01);
            contas.Add(conta02);
            contas.Add(conta03);
            contas.Add(conta04);
            var contemConta = contas.Contains(conta04);
            Console.WriteLine("Contém:" + contemConta);
            Console.WriteLine("Quantidade de contas:" + contas.Count);
            foreach (var item in contas)
            {
                Console.WriteLine(item);
            }
            SortedSet<string> nomes = new SortedSet<string>();
            nomes.Add("Jill001");
            nomes.Add("Jill003");
            nomes.Add("Jill 003");
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }*/

            /*const string nomeArquivo = "Arquivo.txt";
            Stream entrada = File.Open("Arquivo.txt", FileMode.Open);
            if (!(File.Exists(nomeArquivo)))
            {
                File.Open(nomeArquivo, FileMode.Create);
                Console.WriteLine("Arquivo Inexistente");
            }
            var b = entrada.ReadByte(); //ler cada byte
            StreamReader leitor = new StreamReader(entrada);
            var texto = leitor.ReadLine();
            while (texto != null)
            {
                Console.WriteLine(texto);
                texto = leitor.ReadLine();
            }
            leitor.Close();
            entrada.Close();*/

            /*StreamWriter escritor = null;
            Stream saida = null;
            try
            {
                saida = File.Open(nomeArquivo, FileMode.Create);
                escritor = new StreamWriter(saida);
                escritor.WriteLine("Jovem programador");
                escritor.WriteLine("Turma de programação");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (escritor != null)
                {
                    escritor.Close();
                }
                if (saida != null)
                {
                    saida.Close();
                }
            }*/

            /*using (Stream saida = File.Open(nomeArquivo, FileMode.Create))
            {
                using (StreamWriter escritor = new StreamWriter(saida))
                {
                    escritor.WriteLine("Jovem programador 02");
                    escritor.WriteLine("Turma de programação 03");
                }
            }*/

            Conta conta01 = new ContaCorrente(1,1);
            Conta conta02 = new ContaCorrente(1,2);
            Conta conta03 = new ContaCorrente(1,3);
            Conta conta04 = new ContaCorrente(1,4);
            /*
            //Dictionary<string, Cliente> clientes = new  Dictionary<string, Cliente>();
            Cliente cliente01 = new Cliente("000.000.000-00", "Jill");
            Cliente cliente02 = new Cliente("111.111.111-11", "Hinata");
            //clientes.Add(cliente01.Cpf, cliente01);
            //clientes.Add(cliente02.Cpf, cliente02);
            ContaCorrente contaCorrente01 = new ContaCorrente(1,1);
            ContaPoupanca contaPoupanca01 = new ContaPoupanca(1,2);
            contaCorrente01.Titular = cliente01;
            contaPoupanca01.Titular = cliente02;

             Dictionary<string, Conta> contas = new Dictionary<string, Conta>();
            contas.Add(contaCorrente01.Titular.Cpf, contaCorrente01);
            contas.Add(contaPoupanca01.Titular.Cpf, contaPoupanca01);
           */
            List<Conta> contas = new List<Conta>();
            //List<Conta> contasRelatorio = new List<Conta>();
            conta01.Depositar(2000);
            conta02.Depositar(1000);
            conta03.Depositar(1999);
            conta04.Depositar(3000);
            contas.Add(conta01);
            contas.Add(conta02);
            contas.Add(conta03);
            contas.Add(conta04);
            //var filtradas = contas.Where(c => {return c.Saldo > 1999;});
            /*foreach (var item in contas)
            {
                if (item.Saldo > 1999)
                {
                    contasRelatorio.Add(item);
                }
            }
            foreach (var item in contasRelatorio)
            {
                Console.WriteLine(item);
            }*/
            /*var contasRelatorio = from c in contas 
            where c.Saldo > 1999 select c;*/
            var contasRelatorio = from c in contas 
            where c.Saldo > 1999 select new {c.Agencia, c.Numero, c.Titular};
            foreach (var item in contasRelatorio)
            {
                Console.WriteLine(item);
            }
        }
    }
}
