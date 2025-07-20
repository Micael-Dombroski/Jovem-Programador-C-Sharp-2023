using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01.Classes
{
    public class ExceptionRespostaInvalida:Exception
    {
        public ExceptionRespostaInvalida(string message) : base(message)
        {
            
        }
    }
}