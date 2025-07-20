using System.Collections.Generic;
using System.Linq;

namespace exer01
{
    public class CrudConta
    {
        private static List<Conta> contas = new List<Conta>();
        public void Adicionar(Conta conta)
        {
            contas.Add(conta);
        }
        public void Editar(Conta conta)
        {
            foreach (var item in contas)
            {
                if (item.Numero == conta.Numero)
                {
                    contas.Remove(item);
                    contas.Add(conta);
                }
            }
        }
        public List<Conta> Listar()
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
            for (int i = 0; i < contas.Count; i++)
            {
                if (contas[i].Numero == numero)
                {
                    contas.RemoveAt(i);
                }
            }
        }
    }
}