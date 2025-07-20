using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01.Classes
{
    public class ExceptionApenasNumeros:Exception
    {
        public ExceptionApenasNumeros(string message) : base (message)
        {
            
        }
    }
}