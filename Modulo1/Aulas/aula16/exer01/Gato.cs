using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01
{
    public class Gato:Animal
    {
        public Gato(string nome,string dono):base(nome,dono)
        {
            Nome=nome;
            Dono=dono;
        }
        public override string GetCategoria()
        {
            string categoria = "Gato";
            Categoria = categoria;
            return Categoria;
        }
    }
}