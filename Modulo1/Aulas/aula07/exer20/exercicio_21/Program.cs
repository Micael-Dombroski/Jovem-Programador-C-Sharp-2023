using System;

namespace exercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            do
            {
                int c = 1;
                do
                {
                    do 
                    {
                        Console.WriteLine(num + " x " + c + " = " + (num*c));
                        c++;
                    } while (c ==1);
                    do 
                    {
                        Console.WriteLine(num + " x " + c + " = " + (num*c));
                        c++;
                    } while (c ==2);
                    do
                    {
                        Console.WriteLine(num + " x " + c + " = " + (num*c));
                        c++;
                    } while (c ==3);
                    do
                    {
                        Console.WriteLine(num + " x " + c + " = " + (num*c));
                        c++;
                    } while (c ==4);
                    do
                    {
                        Console.WriteLine(num + " x " + c + " = " + (num*c));
                        c++;
                    } while (c ==5);
                    do
                    {
                        Console.WriteLine(num + " x " + c + " = " + (num*c));
                        c++;
                    } while (c ==6);
                    do
                    {
                        Console.WriteLine(num + " x " + c + " = " + (num*c));
                        c++;
                    } while (c ==7);
                    do
                    {
                        Console.WriteLine(num + " x " + c + " = " + (num*c));
                        c++;
                    } while (c ==8);
                    do
                    {
                        Console.WriteLine(num + " x " + c + " = " + (num*c));
                        c++;
                    } while (c ==9);
                    do
                    {
                        Console.WriteLine(num + " x " + c + " = " + (num*c));
                        c++;
                    } while (c ==10);
                } while (c <= 10);
            num++;
            Console.WriteLine(" ");
            } while (num <= 10);
        }
    }
}
