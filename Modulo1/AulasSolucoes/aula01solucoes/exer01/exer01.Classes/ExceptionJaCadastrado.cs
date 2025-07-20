using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01.Classes
{
    public class ExceptionJaCadastrado:Exception
    {
        public ExceptionJaCadastrado(string message) : base (message)
        {

        }
    }
}