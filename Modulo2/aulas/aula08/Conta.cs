using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula08
{
    public class Conta
    {
        public int Agencia {get; set;}
        public int Numero {get; set;}
        public string Correntista {get; set;}
        public double Saldo {get; private set;}
    }
}