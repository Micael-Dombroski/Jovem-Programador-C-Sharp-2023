using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01
{
    public class Peixe:Animal
    {
        public Peixe(string nome, string dono):base(nome,dono)
        {
            Nome=nome;
            Dono=dono;
        }
        public override void DefinirCategoria()
        {
            Categoria = "Peixe";
        }
    }
}