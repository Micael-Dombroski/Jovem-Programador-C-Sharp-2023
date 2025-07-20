using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01
{
    public abstract class Animal
    {
        public string Nome;
        public string Dono;
        protected string Categoria;
        public Animal (string nome, string dono)
        {
            Nome = nome;
            Dono = dono;
        }
        public virtual void DefinirCategoria()
        {

        }
        public string MostrarCategoria()
        {
            return Categoria;
        }
    }
}