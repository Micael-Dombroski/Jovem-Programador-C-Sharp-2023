using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01.Classes
{
    public class ExceptionMuitoPequeno:Exception
    {
        public ExceptionMuitoPequeno(string message) : base (message)
        {

        }
    }
}