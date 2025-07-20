using System;
using System.Collections.Generic;
using System.IO;

namespace aula08._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Conta conta01 = new ContaCorrente();
            conta01.Numero = 1;
            conta01.Agencia = 12;
            conta01.Depositar(1000.50);
            conta01.Titular = new Cliente("000", "Lucas");
            Conta conta02 = new ContaCorrente();
            conta02.Numero = 2;
            conta02.Agencia = 32;
            conta02.Depositar(760.75);
            conta02.Titular = new Cliente("987", "Natally");
            Console.WriteLine(conta01.Equals(conta02));
            Console.WriteLine(conta01.Equals("conta01"));
            List<Conta> contas = new List<Conta>();
            contas.Add(conta01);
            contas.Add(conta02);
            foreach (var item in contas)
            {
                Console.WriteLine("Conta Corrente: " + item.ToString());
            }
            contas.RemoveAt(0);
            Console.WriteLine(contas.Contains(conta01));
            foreach (var item in contas)
            {
                Console.WriteLine("Conta Corrente: " + item.ToString());
            }*/
            
            
            /*Cliente cliente01 = new Cliente("000", "Luna");
            Cliente cliente02 = new Cliente("001", "Ginny");
            Cliente cliente03 = new Cliente("002", "Herione");
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(cliente01);
            clientes.Add(cliente02);
            clientes.Add(cliente03);
            clientes.Add(cliente03);
            foreach (var item in clientes)
            {
                Console.WriteLine(item);
            }
            clientes.Remove(cliente02);
            Console.WriteLine();
            //Console.WriteLine(cliente01);
            //Console.WriteLine(cliente02);
            foreach (var item in clientes)
            {
                Console.WriteLine(item);
            }*/

            //HashSet

            /*Cliente cliente01 = new Cliente("000", "Luna");
            Cliente cliente02 = new Cliente("001", "Ginny");
            Cliente cliente03 = new Cliente("002", "Herione");
            HashSet<string> strings = new HashSet<string>();
            strings.Add("cliente01");
            strings.Add("cliente02");
            strings.Add("cliente03");
            strings.Add("cliente03");
            //strings.Remove("cliente02");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }*/

            /*Cliente cliente01 = new Cliente("000", "Luna");
            Cliente cliente02 = new Cliente("001", "Ginny");
            Cliente cliente03 = new Cliente("002", "Herione");
            HashSet<Cliente> clientes = new HashSet<Cliente>();
            clientes.Add(cliente01);
            clientes.Add(cliente02);
            clientes.Add(cliente03);
            clientes.Add(cliente03);
            foreach (var item in clientes)
            {
                Console.WriteLine(item);
            }
            clientes.Remove(cliente02);
            Console.WriteLine();
            //Console.WriteLine(cliente01);
            //Console.WriteLine(cliente02);
            foreach (var item in clientes)
            {
                Console.WriteLine(item);
            }*/

            //Sorteset

            /*Cliente cliente01 = new Cliente("000", "Luna");
            Cliente cliente02 = new Cliente("001", "Ginny");
            Cliente cliente03 = new Cliente("002", "Herione");
            SortedSet<string> strings = new SortedSet<string>();
            strings.Add("cliente01");
            strings.Add("cliente03");
            strings.Add("cliente03");
            strings.Add("cliente02");
            //strings.Remove("cliente02");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }*/
            const string nomeArquivo = "Arquivo01.txt";
            /*if (!(File.Exists(nomeArquivo)))
            {
                File.Open(nomeArquivo, FileMode.Create);
                Console.WriteLine("Arquivo Inexistente");
            }
            else
            {

            }*/

            /*//var b = entrada.ReadByte(); ler cada byte
            var texto = leitor.ReadLine();
            while (texto != null)
            {
                Console.WriteLine(texto);
                texto = leitor.ReadLine();
            }*/

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

            using (Stream saida = File.Open(nomeArquivo, FileMode.Create))
            {
                using (StreamWriter escritor = new StreamWriter(saida))
                {
                    escritor.WriteLine("Jovem programador 02");
                    escritor.WriteLine("Turma de programação 03");
                }
            }
        }
    }
}
