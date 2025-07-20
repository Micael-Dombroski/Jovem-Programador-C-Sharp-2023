namespace exer02
{
    public class Conta
    {
        public int Agencia;
        public int Numero;
        public Cliente Correntista;
        public double Saldo;
        public Conta (int agencia, int numero, Cliente correntista, double saldo)
        {
            Agencia = agencia;
            Numero = numero;
            Correntista = correntista;
            Saldo = saldo;
        }
        public Conta()
        {

        }
        public bool Sacar(double saque)
        {
            if (Saldo < saque)
            {
                return false;
            }
            Saldo -= saque;
            return true;
        }
        public bool Depositar(double deposito)
        {
            if (0 >= deposito)
            {
                return false;
            }
            Saldo += deposito;
            return true;
        }
        public double SaldoAtual()
        {
            return Saldo;
        }
        public bool Transferir(Conta c1, Conta c2, double valor)
        {
            if (c1.Sacar(valor)==true)
            {
                c2.Depositar(valor);
                return true;
            }
            return false;
        }
        public string CompararContas(Conta c1, Conta c2)
        {
            if (c1.Numero==c2.Numero)
            {
                return "Contas Iguais";
            }
            return "Contas Diferentes";
        }
    }
}