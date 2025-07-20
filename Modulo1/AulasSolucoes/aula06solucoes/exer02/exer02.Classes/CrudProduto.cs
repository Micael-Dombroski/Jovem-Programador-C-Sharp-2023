using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace exer02.Classes
{
    public class CrudProduto
    {
        private Dictionary<string, Produto> Produtos = new Dictionary<string, Produto>();

        public void Cadastrar(Produto produto)
        {
            Produtos.Add(produto.Codigo, produto);
        }

        public Dictionary<string, Produto> ConsultarTodos()
        {
            return Produtos;
        }

        public Produto ConsultarCodigo(string codigo)
        {
            foreach (KeyValuePair<string, Produto> par in Produtos)
            {
                if (par.Key == codigo)
                {
                    return par.Value;
                    break;
                }
            }
            return null;
        }

        public void Editar(Produto produto)
        {
            if (produto.Preco > 0.00)
            {
                foreach (KeyValuePair<string, Produto> par in Produtos)
                {
                    if (par.Key == produto.Codigo)
                    {
                        Produtos.Remove(par.Key);
                        Produtos.Add(produto.Codigo, produto);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("O valor  do Produto não pode ser igual a R$ 0,00 ou inferior");
            }
        }

        public void Excluir(string codigo)
        {
            Produtos.Remove(codigo);
        }
    }
}