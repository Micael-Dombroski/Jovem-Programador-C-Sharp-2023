using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01
{
    public class Vaca:Animal,ICaminhar
    {
        public Vaca(string nome, string dono):base(nome,dono)
        {
            Nome=nome;
            Dono=dono;
        }
        public bool EstaCaminhando(string ler)
        {
            if (ler.ToLower()=="sim")
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public override void DefinirCategoria()
        {
            Categoria = "Vaca";
        }
    }
}