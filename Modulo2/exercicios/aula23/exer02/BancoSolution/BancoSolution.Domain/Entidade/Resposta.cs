using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoSolution.Domain.Entidade
{
    public class Resposta
    {
        public int Codigo {get;set;}
        public string Mensagem {get;set;}
        public Resposta (int codigo, string mensagem)
        {
            Codigo = codigo;
            Mensagem = mensagem;
        }
    }
}