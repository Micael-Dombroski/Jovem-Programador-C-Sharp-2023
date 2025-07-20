using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02
{
    public class DepositoNegativoException : Exception
    {
        public DepositoNegativoException(): base("Proíbido valor Negativo")
        {
        }
    }
}