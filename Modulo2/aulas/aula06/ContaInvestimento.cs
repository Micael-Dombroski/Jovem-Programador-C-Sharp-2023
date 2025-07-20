namespace aula06
{
    public class ContaInvestimento: Conta, IRendimento, ITributavel
    {
        public override bool Sacar(double valor)
        {
            if (Saldo >= valor + 5 && valor > 0)
            {
                Saldo -= valor + 5;
                return true;
            }
            return false;
        }
        public double RendimentoTotal()
        {
            return Saldo*0.1;
        }
        public double CalcularTributo()
        {
            return RendimentoTotal() * 0.15;
        }
    }
}