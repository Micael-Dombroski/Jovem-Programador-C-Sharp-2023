using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerceariaApiSoluction.WebAPIProjeto
{
    public class Resposta
    {
        public int Codigo {get;private set;}
        public string Mensagem {get; private set;}
        public Resposta(int codigo, string mensagem)
        {
            Codigo = codigo;
            Mensagem = mensagem;
        }
    }
}