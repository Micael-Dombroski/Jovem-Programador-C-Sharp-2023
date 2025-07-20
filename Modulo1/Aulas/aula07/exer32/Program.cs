using System;

namespace exer32
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int res = 1;
            Console.Write(n1 + "," + n2);
            do
            {
                Console.Write(",");
                res = n1 + n2;
                Console.Write(res);
                n1 = n2;
                n2 = res;
                
            } while (res <= 100);
        }
    }
}
