using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01
{
    public class Vaca:Animal
    {
        public Vaca(string nome,string dono):base(nome,dono)
        {
            Nome=nome;
            Dono=dono;
        }
        public override string GetCategoria()
        {
            string categoria = "Vaca";
            Categoria = categoria;
            return Categoria;
        }
    }
}