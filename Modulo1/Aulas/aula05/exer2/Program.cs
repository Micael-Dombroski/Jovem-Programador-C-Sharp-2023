using System;
namespace exer2 
{
    class Program 
    {
        static void Main(string[] args)
        {
            int numeroInteiro = 10;
            decimal v1 = Convert.ToDecimal(numeroInteiro);
            //decimal v1 = (decimal)numeroInteiro;
            decimal numeroDecimal = 23.5m;
            int v2 = (int)numeroDecimal;
            string numeroEmString = "78";
            int v3 = Convert.ToInt32(numeroEmString);
            decimal v4 = Convert.ToDecimal(numeroEmString);
            double numeroDouble = 3.71;
            decimal v5 = Convert.ToDecimal(numeroDouble);

           Console.WriteLine(v1);
           //Console.WriteLine((v1/3)); comprovando que é decimal
           Console.WriteLine(v2 + "m");
           Console.WriteLine(v3);
           Console.WriteLine(v4);
           Console.WriteLine(v5);
           
        }
    }
}