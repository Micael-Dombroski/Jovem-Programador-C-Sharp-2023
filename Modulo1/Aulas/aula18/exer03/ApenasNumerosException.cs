using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer03
{
    public class ApenasNumerosException: Exception
    {
        public ApenasNumerosException(string message) : base (message)
        {
            
        }
    }
}