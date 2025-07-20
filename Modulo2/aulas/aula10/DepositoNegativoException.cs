using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula10
{
    public class DepositoNegativoException : Exception
    {
        public DepositoNegativoException(): base("Proíbido valor Negativo")
        {
        }
    }
}