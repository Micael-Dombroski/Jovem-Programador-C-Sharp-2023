using System;
namespace exer1 {
    class Program {
        static void Main (String [] args) {
            string valor1 = "76";
            string valor2 = "24";
            int num1 = Convert.ToInt32(valor1);
            var num2 = Int32.Parse(valor2);
            var soma = num1 + num2;
            Console.WriteLine(soma);
        }
    }
}