using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace exer01.Classes
{
    public class CrudConta : Conta
    {
        private Dictionary<String, Conta> Contas;
        public CrudConta(int agencia, int numero, Correntista correntista):base( agencia, numero, correntista)
        {
            Contas = new Dictionary<String, Conta>();
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
                        escritor.WriteLine(" Lista de Contas");
                        escritor.WriteLine(" Agência | Número | Tipo | Nome       | CPF");
                        foreach (KeyValuePair<string, Conta> par in Contas)
                        {
                            Conta item = par.Value;
                            string cpf = item.Correntista.Cpf;
                            escritor.Write($" {item.Agencia} |");
                            escritor.Write($" {item.Numero} |");
                            escritor.Write($" {item.Tipo} |");
                            escritor.Write($" {item.Correntista.Nome} |");
                            escritor.WriteLine($" {cpf[0]}{cpf[1]}{cpf[2]}.{cpf[3]}{cpf[4]}{cpf[5]}.{cpf[6]}{cpf[7]}{cpf[8]}-{cpf[9]}{cpf[10]}");
                        }
                    }
                }
            } 
        }
    }
}