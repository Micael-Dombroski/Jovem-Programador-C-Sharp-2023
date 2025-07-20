using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula07
{
    public class TotalizadorRendimento
    {
        public double TotalRendimento {get; private set;}
        public void SomarRendimento(IRendimento rendimento)
        {
            TotalRendimento += double.Parse(rendimento.RendimentoTotal().ToString("F"));
        }
    }
}