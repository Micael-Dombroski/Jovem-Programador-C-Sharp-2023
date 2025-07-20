namespace exer01
{
    public class TotalizadorContas
    {
        public double Total {get; private set;}
        public void SomarSaldo(Conta conta)
        {
            if (conta is ContaPoupanca)
            {
                ContaPoupanca poupanca= (ContaPoupanca)conta;
                Total+= poupanca.CalcularRendimento(); 
            }
            else if (conta is ContaInvestimento)
            {
                ContaInvestimento investimento = (ContaInvestimento)conta;
                Total+=investimento.CalcularRendimento();
                Total-=investimento.CalcularTributo(); 
            }
            else if (conta is ContaCorrente)
            {
                ContaCorrente corrente = (ContaCorrente)conta;
                Total-=corrente.CalcularTributo();
            }
            Total+=conta.Saldo;
        }
        public void RemoverSaldo(Conta conta)
        {
            if (conta is ContaPoupanca)
            {
                ContaPoupanca poupanca= (ContaPoupanca)conta;
                Total-= poupanca.CalcularRendimento(); 
            }
            else if (conta is ContaInvestimento)
            {
                ContaInvestimento investimento = (ContaInvestimento)conta;
                Total-=investimento.CalcularRendimento();
                Total+=investimento.CalcularTributo(); 
            }
            else if (conta is ContaCorrente)
            {
                ContaCorrente corrente = (ContaCorrente)conta;
                Total+=corrente.CalcularTributo();
            }
            Total-=conta.Saldo;
        }
        public override string ToString()
        {
            return $"Total de Todas as Contas: R$ {Total.ToString("F")}";
        }
    }
}