using System;

namespace exer05
{
    class Program
    {
        static void Main(string[] args)
        {
            var  data = DateTime.Now;
            Console.WriteLine("Quantos funcionários solicitaram aposentadoria?");
            var ler = Console.ReadLine();
            int n = Convert.ToInt32(ler);
            int maiornome = 0;
            string [] nome = new string [n];
            int [] idade = new int [n];
            int [] anostrabalhados = new int [n];
            string [] vaiaposentar = new string [n];
            int [,] datainiciodetrab = new int [n,3];
            string [] tempcont = new string [n];
            int [] tempodecont = new int [3];
            for (int c = 0; c < n; c++)
            {
                Console.Write("Informe o nome do Funcionário " + (c+1) + ": ");
                ler = Console.ReadLine();
                nome[c] = nomefuncionario(nome[c],ler);
                if (maiornome < nome[c].Length)
                {
                    maiornome = nome[c].Length;
                }
                idade[0] = 0;
                Console.WriteLine("");
                Console.Write("Informe a idade do Funcionário " + (c+1) + ": ");
                ler = Console.ReadLine();
                int lerint = Convert.ToInt32(ler);
                idade[c] = idadefuncionario(idade[c],lerint);
                if (idade[c] == 0) {
                    Console.WriteLine("A idade informada é muito baixa, informe outra idade...");
                    Console.Write("Informe a idade do Funcionário " + (c+1) + ": ");
                    ler = Console.ReadLine();
                    lerint = Convert.ToInt32(ler);
                    idade[c] = idadefuncionario(idade[c],lerint);
                }
                Console.WriteLine("");
                anostrabalhados[c] = 0;
                Console.Write("Em que ano o Funcionário " + (c+1) + " começou a trabalhar?");
                ler = Console.ReadLine();
                datainiciodetrab [c,0] = Convert.ToInt32(ler);
                Console.WriteLine();
                Console.Write("Em que mês o Funcionário " + (c+1) + " começou a trabalhar?");
                ler = Console.ReadLine();
                datainiciodetrab [c,1] = Convert.ToInt32(ler);
                Console.WriteLine();
                Console.Write("Em que dia o Funcionário " + (c+1) + " começou a trabalhar?");
                ler = Console.ReadLine();
                datainiciodetrab [c,2] = Convert.ToInt32(ler);
                Console.WriteLine();
                Console.Write("Informe os anos trabalhados do Funcionário " + (c+1) + ": ");
                ler = Console.ReadLine();
                lerint = Convert.ToInt32(ler);
                anostrabalhados[c] = tempdtrabalho(anostrabalhados[c], lerint, idade[c]);
                int dia = data.Day;
                int mes = data.Month;
                int ano = data.Year;
                tempodecont[2] = dia - datainiciodetrab[c,2];
                if (tempodecont[2] < 1)
                {
                    tempodecont[1] = mes - datainiciodetrab[c,1] - 1;
                    if (tempodecont[1] < 1)
                    {
                        tempodecont[1] = 12 + tempodecont[1];
                        tempodecont[0] = ano - datainiciodetrab[c,0] - 1 ;
                    }
                    if (tempodecont[1] == 1 || tempodecont[1] == 3 || tempodecont[1] == 5 || tempodecont[1] == 7 || tempodecont[1] == 8 || tempodecont[1] == 10 || tempodecont[1] == 12)
                    {
                        tempodecont[2] = 31 + tempodecont[2];
                    } else if (tempodecont[1] == 2)
                    {
                        tempodecont[2] = 28 + tempodecont[2];
                    } else 
                    {
                        tempodecont[2] = 30 + tempodecont[2];
                    }
                } else 
                {
                    tempodecont[1] = mes - datainiciodetrab[c,1];
                    if (tempodecont[1] < 1)
                    {
                        tempodecont[1] = 12 + tempodecont[1];
                        tempodecont[0] = ano - datainiciodetrab[c,0] - 1;
                    } else 
                    {
                        tempodecont[0] = ano - datainiciodetrab[c,0];
                    }
                }
                int divano = tempodecont[0]/4;
                if (divano > 0)
                {
                    tempodecont[2] -= divano;
                    if (tempodecont[2] < 1)
                    {
                        tempodecont[1] -= 1;
                        if (tempodecont[1] < 1)
                        {
                            tempodecont[1] = 12 + tempodecont[1];
                            tempodecont[0] -= 1;
                        }
                        if (tempodecont[1] == 1 || tempodecont[1] == 3 || tempodecont[1] == 5 || tempodecont[1] == 7 || tempodecont[1] == 8 || tempodecont[1] == 10 || tempodecont[1] == 12)
                        {
                            tempodecont[2] = 31 + tempodecont[2];
                        } else if (tempodecont[1] == 2)
                        {
                            tempodecont[2] = 28 + tempodecont[2];
                        } else 
                        {
                            tempodecont[2] = 30 + tempodecont[2];
                        }
                    }
                }
                tempcont[c]=$"{tempodecont[0]} anos {tempodecont[1]} meses e {tempodecont[2]} dias";
                while (anostrabalhados[c] != tempodecont[0])
                {
                    Console.WriteLine("3RR0R: Os anos  trabalhados não coincidem com a   data de quando o funcionário começou a trabalhar...");
                    //Console.WriteLine(tempcont[c]);
                    //Console.WriteLine($"{ano} - {datainiciodetrab[c,0]} = {ano - datainiciodetrab[c,0]}");
                    Console.Write("Informe os anos trabalhados do Funcionário " + (c+1) + ": ");
                    ler = Console.ReadLine();
                    lerint = Convert.ToInt32(ler);
                    anostrabalhados[c] = tempdtrabalho(anostrabalhados[c], lerint, idade[c]);
                }
                if (anostrabalhados[c] == 0)
                {
                    Console.WriteLine("A idade do funcionário não pode ser  inferior ao seus anos trabalhados...");
                    Console.Write("Informe os anos trabalhados do Funcionário " + (c+1) + ": ");
                    ler = Console.ReadLine();
                    lerint = Convert.ToInt32(ler);
                    while (anostrabalhados[c] != tempodecont[0])
                    {
                        Console.WriteLine("3RR0R: Os anos  trabalhados não coincidem com a   data de quando o funcionário começou a trabalhar...");
                        Console.Write("Informe os anos trabalhados do Funcionário " + (c+1) + ": ");
                        ler = Console.ReadLine();
                        lerint = Convert.ToInt32(ler);

                    }
                }
                Console.WriteLine("");
                vaiaposentar[c] = vaiapos(idade[c], anostrabalhados[c]);
                
                
            }
            Console.WriteLine("Relatório...");
            Console.Write("Nome");
            for (int c =0; c < maiornome + 4; c++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("Idade          Tempo de Contribuição         Situação");
            Console.Write("----");
            for (int c =0; c < maiornome + 6; c++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("-----          ---------------------          --------");
            for (int c = 0; c < n; c++)
            {
                    Console.Write(nome[c]);
                    int nspaces = (maiornome-nome[c].Length) + 7;
                    for (int c1 = 0; c1 < nspaces; c1++)
                    {
                        Console.Write(" ");
                    }
                    if (idade[c] < 10) {
                        Console.Write("0" + idade[c] + " anos");
                    } else
                    {
                        Console.Write(idade[c] + " anos");
                    }
                    Console.Write("        ");
                    Console.Write(tempcont[c]);
                    /*if (anostrabalhados[c] < 10) {
                        Console.Write("0" + anostrabalhados[c] + " anos");
                    } else
                    {
                        Console.Write(anostrabalhados[c] + " anos");
                    }*/
                    Console.Write("          ");
                    Console.WriteLine(vaiaposentar[c]);
            }
        }
        static string nomefuncionario (string v1,  string v2)
        {
            v1 = v2;
            return v1;
        }
        static int idadefuncionario (int v1,  int v2)
        {
            if (v2 > 13)
            {
                v1=v2;
            }
            return v1;
        }
        static  int tempdtrabalho (int v1, int v2, int v3)
        {
            if (v2 < v3)
            {
                v1=v2;
            }
            return v1;
        }
        static string vaiapos (int v1, int v2)
        {
            if (v1 > 64 || v2 > 34 || (v1 > 59 && v2 > 25))
            {
                return "Sim";
            } else
            {
                return "Não";
            }
        }
    }
}
