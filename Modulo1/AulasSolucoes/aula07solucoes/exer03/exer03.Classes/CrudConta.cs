using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace exer03.Classes
{
    public class CrudConta:Conta
    {
        private static int Index = 0;
        private List<Conta> contas;
        public CrudConta()
        {
            contas = new List<Conta>();
        }

        public void Cadastrar(Conta conta)
        {
            contas.Add(conta);
            ArquivandoDados();
        }

        public List<Conta> ConsultarTodos()
        {
            return contas;
        }

        public int  MostrarTamanho()
        {
            Index = 0;
            return contas.Count;
        }

        public Conta PassarCadaItem()
        {
            return contas[Index];
            Index++;
        }

        public Conta ConsultarNumero(int numero)
        {
            foreach (var item in contas)
            {
                if (item.Numero == numero)
                {
                    return item;
                }
            }
            return null;
        }

        public void Editar(Conta conta1,Conta conta2)
        {
            contas.Remove(conta1);
            contas.Add(conta2);
            ArquivandoDados();
        }

        public void Excluir(Conta conta)
        {
            contas.Remove(conta);
            ArquivandoDados();
        }
        public void ArquivandoDados()
        {
            if (File.Exists("conta.txt"))
            {
                File.Delete("conta.txt");
            }
            if (!File.Exists("conta.txt"))
            {
                using (Stream saida = File.Open("conta.txt", FileMode.Create))
                {
                    using (StreamWriter escritor = new StreamWriter(saida))
                    {
                        escritor.WriteLine(" Lista de Contas");
                        escritor.WriteLine(" Agencia | Número | Correntista | Saldo");
                        foreach (Conta conta in contas)
                        {
                            escritor.Write($"      {conta.Agencia}     |");
                            escritor.Write($"  {conta.Numero}  |");
                            escritor.Write($" {conta.Correntista.Nome}  |");
                            escritor.WriteLine($"   R$ {conta.Saldo}");
                        }
                    }
                }
            }
        }
    }
}