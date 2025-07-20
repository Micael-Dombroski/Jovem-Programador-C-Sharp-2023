namespace aula06
{
    public class ContaCorrente : Conta
    {
        public override bool Sacar(double valor)
        {
            if (Saldo >= valor + 2 && valor > 0)
            {
                Saldo -= valor + 2;
                return true;
            }
            return false;
        }
        /*public override void Depositar(double valor)
        {
            base.Depositar(valor);
        }*/
    }
}