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
        public Animal(string nome,string dono)
        {
            Nome = nome;
            Dono = dono;
        }
        public string ShowCategoria()
        {
            return Categoria;
        }
        public virtual string GetCategoria()
        {
            string categoria = "";
            Categoria = categoria;
            return Categoria;
        }
    }
}