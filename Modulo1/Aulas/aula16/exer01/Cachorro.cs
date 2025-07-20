using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01
{
    public class Cachorro:Animal
    {
        
        public Cachorro(string nome,string dono):base(nome,dono)
        {
            Nome=nome;
            Dono=dono;
        }
        public override string GetCategoria()
        {
            string categoria = "Cachorro";
            Categoria = categoria;
            return Categoria;
        }
        
    }
}