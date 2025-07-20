using System.Collections.Generic;
using System.Linq;

namespace exer02
{
    public class CrudConta
    {
        private static Conta [] contas = new Conta[0];
        public void Adicionar(Conta conta)
        {
            Conta [] aumentar = new Conta[contas.Length+1];
            if (contas.Length == 0)
            {

            }
            else
            {
                for (int i = 0; i < contas.Length; i++)
                {
                    aumentar[i] = contas[i];
                }
            }
            aumentar[contas.Length] = conta;
            contas = aumentar;
        }
        public void Editar(Conta conta)
        {
            foreach (var item in contas)
            {
                if (item.Numero == conta.Numero)
                {
                    Excluir(item.Numero);
                    Adicionar(conta);
                }
            }
        }
        public Conta [] Listar()
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
            var reduzir = contas.ToList();
            for (int i = 0; i < reduzir.Count; i++)
            {
                if (reduzir[i].Numero == numero)
                {
                    reduzir.RemoveAt(i);
                }
            }
            contas = reduzir.ToArray();
        }
    }
}