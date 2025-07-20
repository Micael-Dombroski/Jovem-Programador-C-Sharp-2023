using System;

namespace exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.Write("[  A  ]");
            Console.Write("[  B  ]");
            Console.Write("[  !A ]");
            Console.WriteLine("");
            Console.Write("[" + (a == 1) + " ]");
            Console.Write("[" + (b == 2) + " ]");
            Console.Write("[" + (a == 2) + "]");
            Console.WriteLine("");
            Console.Write("[" + (a == 1) + " ]");
            Console.Write("[" + (b == 1) + "]");
            Console.Write("[" + (a == 2) + "]");
            Console.WriteLine("");
            Console.Write("[" + (a == 2) + "]");
            Console.Write("[" + (b == 1) + "]");
            Console.Write("[" + (a == 1) + " ]");
            Console.WriteLine("");
            Console.Write("[" + (a == 2) + "]");
            Console.Write("[" + (b == 2) + " ]");
            Console.Write("[" + (a == 1) + " ]");


            Console.WriteLine("\n");
            Console.Write("[  A  ]");
            Console.Write("[  B  ]");
            Console.Write("[A AND B ]");
            Console.Write("[  !A ]");
            Console.WriteLine("");
            Console.Write("[" + (a < 2) + " ]");
            Console.Write("[" + (b > 0) + " ]");
            Console.Write("[  " + (a == 1 && b > 1) + "  ]");
            Console.Write("[" + (a > 1) + "]");
            Console.WriteLine("");
            Console.Write("[" + (a < 2) + " ]");
            Console.Write("[" + (b < 0) + "]");
            Console.Write("[  " + (a == 1 && b < 1) + " ]");
            Console.Write("[" + (a > 1) + "]");
            Console.WriteLine("");
            Console.Write("[" + (a > 2) + "]");
            Console.Write("[" + (b > 0) + " ]");
            Console.Write("[  " + (a < 1 && b > 1) + " ]");
            Console.Write("[" + (a == 1) + " ]");
            Console.WriteLine("");
            Console.Write("[" + (a > 2) + "]");
            Console.Write("[" + (b < 0) + "]");
            Console.Write("[  " + (a < 1 && b < 1) + " ]");
            Console.Write("[" + (a == 1) + " ]");


            Console.WriteLine("\n");
            Console.Write("[  A  ]");
            Console.Write("[  B  ]");
            Console.Write("[A OR B ]");
            Console.Write("[  !B ]");
            Console.WriteLine("");
            Console.Write("[" + (a >= 1) + " ]");
            Console.Write("[" + (b <= 2) + " ]");
            Console.Write("[ " + (a == 1 || b == 2) + "  ]");
            Console.Write("[" + (b > 2) + "]");
            Console.WriteLine("");
            Console.Write("[" + (a >= 1) + " ]");
            Console.Write("[" + (b < 2) + "]");
            Console.Write("[ " + (a == 1 || b < 2) + "  ]");
            Console.Write("[" + (b == 2) + " ]");
            Console.WriteLine("");
            Console.Write("[" + (a > 1) + "]");
            Console.Write("[" + (b <= 2) + " ]");
            Console.Write("[ " + (a > 1 || b == 2) + "  ]");
            Console.Write("[" + (b > 2) + "]");
            Console.WriteLine("");
            Console.Write("[" + (a > 1) + "]");
            Console.Write("[" + (b < 2) + "]");
            Console.Write("[ " + (a > 1 || b > 2) + " ]");
            Console.Write("[" + (b == 2) + " ]");


            Console.WriteLine("\n");
            Console.Write("[  A  ]");
            Console.Write("[  B  ]");
            Console.Write("[A AND !B]");
            Console.Write("[  !B ]");
            Console.WriteLine("");
            Console.Write("[" + (a <= 1) + " ]");
            Console.Write("[" + (b < 3) + " ]");
            Console.Write("[  " + (a >= 1 && b != 2) + " ]");
            Console.Write("[" + (b == 1) + "]");
            Console.WriteLine("");
            Console.Write("[" + (a <= 1) + " ]");
            Console.Write("[" + (b == 3) + "]");
            Console.Write("[  " + (a >= 1 && b == 2) + "  ]");
            Console.Write("[" + (b > 1) + " ]");
            Console.WriteLine("");
            Console.Write("[" + (a < 1) + "]");
            Console.Write("[" + (b < 3) + " ]");
            Console.Write("[  " + (a > 1 && b != 2) + " ]");
            Console.Write("[" + (b == 1) + "]");
            Console.WriteLine("");
            Console.Write("[" + (a < 1) + "]");
            Console.Write("[" + (b == 3) + "]");
            Console.Write("[  " + (a > 1 && b == 2) + " ]");
            Console.Write("[" + (b == 2) + " ]");
        }
    }
}
