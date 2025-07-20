using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula08._1
{
    public class TotalizadorDeTributos
    {
        public double Total {get; private set;}

        public void Acumula (ITributavel t)
        {
            Total += t.CalcularTributo();
        }
    }
}