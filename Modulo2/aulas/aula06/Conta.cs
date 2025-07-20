namespace aula06
{
    public abstract class Conta
    {
        public int Agencia {get; set;}
        public int Numero {get; set;}
        /*public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }*/
        public Cliente Titular {get; set;}
        public double Saldo {get; protected set;}

        /*public double Saldo
        {
            get
            {
                return saldo;
            }
        }*/

        public abstract bool Sacar(double valor);
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

    }
}