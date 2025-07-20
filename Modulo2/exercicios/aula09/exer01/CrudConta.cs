using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace exer01
{
    public class CrudConta
    {
        private static string nomeArquivo = "Contas.txt";
        private static Dictionary<int, Conta> contas = new Dictionary<int, Conta>();
        public void Adicionar(Conta conta)
        {
            contas.Add(conta.Numero, conta);
            AtualizarBD();
        }
        public void Editar(Conta conta)
        {
            Excluir(conta.Numero);
            Adicionar(conta);
        }
        public Dictionary<int,Conta> Listar()
        {
            return contas;
        }
        public Conta Consultar(int numero)
        {
            foreach (KeyValuePair<int, Conta> par in contas)
            {
                if (par.Key == numero)
                {
                    return par.Value;
                    break;
                }
            }
            return null;
        }
        public void Excluir(int numero)
        {
            Conta conta = Consultar(numero);
            if (conta != null)
            {
                contas.Remove(conta.Numero);
            }
            AtualizarBD();
        }
        public void AtualizarBD()
        {
            using (Stream saida = File.Open(nomeArquivo, FileMode.Create))
            {
                using (StreamWriter escritor = new StreamWriter(saida))
                {
                   foreach (var item in Listar())
                   {
                        escritor.WriteLine(item.ToString());
                   }
                }
            }
        }
    }
}