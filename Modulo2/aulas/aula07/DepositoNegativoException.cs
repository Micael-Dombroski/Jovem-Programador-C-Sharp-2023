using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula07
{
    public class DepositoNegativoException : Exception
    {
        public DepositoNegativoException(): base("Proíbido valor Negativo")
        {
        }
    }
}