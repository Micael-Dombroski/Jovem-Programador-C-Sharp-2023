namespace exer04
{
    public class Cliente
    {
        private static int ID {get;set;}
        public string RazaoSocial {get;set;}
        public string NomeFantasia {get;set;}
        public string CNPJ {get;set;}
        private double SaldoCredito {get;set;}
        public double SaldoAtual {get;set;}
        private int IdCliente {get;set;}
        public Cliente (string razaoSocial, string nomeFantasia, string cnpj, double saldoCredito)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            CNPJ = cnpj;
            SaldoCredito = saldoCredito;
            SaldoAtual = saldoCredito;
            ID++;
            IdCliente = ID;
        }
        public bool GastarCredito(double valor)
        {
            if (valor > SaldoAtual)
            {
                return false;
            }
            SaldoAtual -= valor;
            return true;
        }
        public double SaldoGastado()
        {
            return SaldoCredito - SaldoAtual;
        }
        public int MostrarID()
        {
            return IdCliente;
        }
    }
}