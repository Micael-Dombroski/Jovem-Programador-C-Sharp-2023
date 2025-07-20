using System;

namespace Protected
{
    public class Animal
    {
        protected string nome;
        private double valor;
        public double getValor ()
        {
            return valor;
        }
        public Animal(double valor)
        {
            this.valor=valor;
        }
    }
    /*public class Macaco:Animal
    {
        public Macaco(double valor)
        {
            nome="macaco";
        }
        public string getNome()
        {
            return nome;
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal (200.0);
            Console.WriteLine(animal.getValor());
        }
    }
}
