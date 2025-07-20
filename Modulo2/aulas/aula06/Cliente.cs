namespace aula06
{
    public class Cliente
    {
        public string Cpf {get; set;}
        public string Rg {get; set;}
        public string Nome {get; set;}
        public string Endereco {get; set;}

        public Cliente(string cpf, string rg, string nome)
        {
            this.Cpf = cpf;
            this.Rg = rg;
            this.Nome = nome;
        }

        public Cliente(string cpf, string nome)
        {
            this.Cpf = cpf;
            this.Nome = nome;
        }
    }
}