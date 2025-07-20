namespace exer04
{
    public class Fornecedor
    {
        public static int ID {get;set;}
        public string RazaoSocial {get;set;}
        public string NomeFantasia {get;set;}
        public string CNPJ {get;set;}
        private int IdFornecedor {get;set;}
        public Fornecedor (string razaoSocial, string nomeFantasia, string cnpj)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            CNPJ = cnpj;
            ID++;
            IdFornecedor = ID;
        }
        public int MostrarID()
        {
            return IdFornecedor;
        }
    }
}