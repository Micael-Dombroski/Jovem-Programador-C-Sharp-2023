using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoSolution.Domain.Entidade
{
    public class Usuario
    {
        public int Id {get;set;}
        public string LoginUsuario {get;set;}
        public string SenhaUsuario {get;set;}
        public override bool Equals(object obj)
        {
            if (obj is Usuario)
            {
                Usuario usuario = (Usuario)obj;
                if (usuario.Id == Id)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}