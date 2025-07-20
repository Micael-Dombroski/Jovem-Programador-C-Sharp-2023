using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01.Classes
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
        }

        public void Excluir(Conta conta)
        {
            contas.Remove(conta);
        }
    }
}