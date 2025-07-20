using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01.Classes
{
    public class Conta
    {
        public int Agencia {get;set;}
        public int Numero {get;set;}
        public int Tipo {get;set;}
        public Correntista Correntista {get;set;}
        public Conta (int agencia, int numero, Correntista correntista)
        {
            Agencia = agencia;
            Numero = numero;
            Correntista = correntista;
        }
    }
}