using System;

namespace exer31
{
    class Program
    {
        static void Main(string[] args)
        {
            int semana = 0;
            Console.WriteLine("Pressione qualquer tecla para começar.");
            Console.ReadKey();
            while (semana < 52) {
                semana++;
                Console.WriteLine("Semana " + semana);
                Console.ReadKey();
                for (int dia = 1; dia <= 7; dia++)
                {       
                    Console.WriteLine("Dia " + dia);
                    for (int hora = 0; hora < 24; hora++)
                    {
                        for (int minuto = 0; minuto < 60; minuto ++)
                        {

                            for (int segundo = 0; segundo < 60; segundo ++)
                            {
                                if (hora < 10) {
                                    if (minuto < 10) {
                                        if (segundo < 10) {
                                            Console.WriteLine("0" + hora + ":" + "0" + minuto + ":" + "0" + segundo);
                                        } else {
                                            Console.WriteLine("0" + hora + ":" + "0" + minuto + ":" + segundo);
                                        }
                                    } else {
                                        if (segundo < 10) {
                                            Console.WriteLine("0" + hora + ":" + minuto + ":" + "0" + segundo);
                                        } else {
                                            Console.WriteLine("0" + hora + ":" + minuto + ":" + segundo);
                                        }
                                    }
                                } else if (minuto < 10) {
                                    if (segundo < 10) {
                                        Console.WriteLine(hora + ":" + "0" + minuto + ":" + "0" + segundo);
                                    } else {
                                        Console.WriteLine(hora + ":" + "0" + minuto + ":" + segundo);
                                    }
                                } else if (segundo < 10) {
                                    Console.WriteLine(hora + ":" + minuto + ":" + "0" + segundo);
                                } else {
                                    Console.WriteLine(hora + ":" + minuto + ":" + segundo);
                                }
                            }

                        }
                    }
                }
                Console.WriteLine("Quer ir para a próxima semana? Pressione qualquer tecla!");
                Console.ReadKey();
            }
            Console.WriteLine("Você está na semana " + semana + "!");
        }
    }
}
