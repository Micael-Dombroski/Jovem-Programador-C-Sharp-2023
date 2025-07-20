using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer03
{
    public class MuitoPequenoException:Exception
    {
        public MuitoPequenoException(string message) : base (message)
        {

        }
    }
}