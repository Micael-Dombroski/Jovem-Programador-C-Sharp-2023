using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace exer01
{
    public class CrudConta
    {
        private static string nomeArquivo = "Contas.txt";
        private static HashSet<Conta> contas = new HashSet<Conta>();
        public void Adicionar(Conta conta)
        {
            contas.Add(conta);
            AtualizarBD();
        }
        public void Editar(Conta conta)
        {
            Excluir(conta.Numero);
            Adicionar(conta);
        }
        public HashSet<Conta> Listar()
        {
            return contas;
        }
        public Conta Consultar(int numero)
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
        public void Excluir(int numero)
        {
            Conta conta = Consultar(numero);
            if (conta != null)
            {
                contas.Remove(conta);
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