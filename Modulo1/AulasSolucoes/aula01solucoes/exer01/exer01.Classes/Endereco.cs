using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01.Classes
{
    public struct Endereco
    {
        public string Rua;
        public string Numero;
        public string Bairro;
        public string Cidade;
        public string Estado;
        public Endereco (string rua, string numero, string bairro, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}