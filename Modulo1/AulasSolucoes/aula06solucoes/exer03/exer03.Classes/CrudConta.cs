using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace exer03.Classes
{
    public class CrudConta : Conta
    {
        private Dictionary<String, Conta> Contas;
        private Correntista Correntista;
        public CrudConta(int agencia, int numero, Correntista correntista):base( agencia, numero, correntista)
        {
            Contas = new Dictionary<String, Conta>();
            CarregandoDados();
        }

        public void Cadastrar(Conta conta)
        {
            Contas.Add(conta.Correntista.Cpf, conta);
            ArquivandoDados();
        }

        public Dictionary<String, Conta> ConsultarTodos()
        {
            return Contas;
        }

        public Conta ConsultarCPF(string cpf)
        {
            foreach (KeyValuePair<string, Conta> par in Contas)
            {
                if (par.Key == cpf)
                {
                    return par.Value;
                    break;
                }
            }
            return null;
        }

        public void Editar(Conta conta)
        {
            foreach (KeyValuePair<string, Conta> par in Contas)
            {
                if (par.Key == conta.Correntista.Cpf)
                {
                    Contas.Remove(par.Key);
                    Contas.Add(conta.Correntista.Cpf, conta);
                    break;
                }
            }
            ArquivandoDados();
        }

        public void Excluir(string cpf)
        {
            Contas.Remove(cpf);
            if (File.Exists("Conta.txt"))
            {
                File.Delete("Conta.txt");
            }
            ArquivandoDados();
        }
        public void ArquivandoDados()
        {
            if (File.Exists("Conta.txt"))
            {
                File.Delete("Conta.txt");
            }
            if (!File.Exists("Conta.txt"))
            {
                using (Stream saida = File.Open("Conta.txt", FileMode.Create))
                {
                    using (StreamWriter escritor = new StreamWriter(saida))
                    {
                        escritor.WriteLine("Lista de Contas");
                        escritor.WriteLine("Agência|Número|Tipo|Nome|CPF");
                        foreach (KeyValuePair<string, Conta> par in Contas)
                        {
                            escritor.WriteLine(par.Value.ToString());
                        }
                    }
                }
            } 
        }
        public void CarregandoDados()
        {
            if (File.Exists("Conta.txt"))
            {
                using (Stream entrada = File.Open("Conta.txt", FileMode.OpenOrCreate))
                {
                    using (StreamReader leitor = new StreamReader(entrada))
                    {
                        string linha = leitor.ReadLine();
                        linha = leitor.ReadLine();
                        linha = leitor.ReadLine();
                        while (linha != null)
                        {
                            var contaString = linha.Split("|");
                            Console.WriteLine(contaString[0]);
                            Console.WriteLine(contaString[1]);
                            Console.WriteLine(contaString[2]);
                            Console.WriteLine(contaString[3]);
                            Console.WriteLine(contaString[4]);
                            Correntista = new Correntista(contaString[3], contaString[4]);
                            int agencia = Convert.ToInt32(contaString[0]);
                            int numero = Convert.ToInt32(contaString[1]);
                            Conta conta = new Conta(agencia, numero, Correntista);
                            conta.Tipo = Convert.ToInt32(contaString[2]);
                            Contas = new Dictionary<String, Conta>();
                            Contas.Add(conta.Correntista.Cpf, conta);
                            
                            linha = leitor.ReadLine();
                        }
                    }
                }
            }
        }
    }
}