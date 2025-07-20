using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01
{
    public class Cachorro:Animal,ICaminhar
    {
        public Cachorro(string nome, string dono):base(nome,dono)
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
            Categoria = "Cachorro";
        }
    }
}