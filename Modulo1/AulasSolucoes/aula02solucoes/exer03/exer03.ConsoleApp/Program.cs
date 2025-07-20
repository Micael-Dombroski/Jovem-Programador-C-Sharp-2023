using System;
using exer03.Classes;
using System.Collections.Generic;

namespace exer03.ConsoleApp
{
    class Program
    {
        static string resposta = "";
        static List<string> historico = new List<string>();
        static void Main(string[] args)
        {
            string ler;
            int opt=0;
            double n1 = 0.0;
            double n2 = 0.0;
            bool Num1 = true;
            bool Num2 = true;
            int contVirgula = 0;
            do
            {
                do
                {
                    try 
                    {
                        Console.WriteLine("Qual operação você deseja fazer: ");
                        Console.WriteLine("1-Soma");
                        Console.WriteLine("2-Subtração");
                        Console.WriteLine("3-Divisão");
                        Console.WriteLine("4-Multiplicação");
                        Console.WriteLine("5-Potência Base 2");
                        Console.WriteLine("6-Potência");
                        Console.WriteLine("7-Mostrar Histórico");
                        Console.Write("Informe o número da opção desejada: ");
                        ler = Console.ReadLine();
                        int eNumero = ler[0];
                        if ((eNumero > 57 || eNumero < 48) && ler.Length == 1)
                        {
                            throw new ArgumentException("Esse campo só pode receber valores numéricos");
                        } else
                        {
                            opt = Convert.ToInt32(ler);
                            try
                            {
                                if (opt < 1 || opt > 6)
                                {
                                    throw new ArgumentOutOfRangeException("O valor informado precisar ser um número inteiro entre 1 e 6");
                                }
                            } catch (ArgumentOutOfRangeException e)
                            {
                                Console.WriteLine(e.Message);
                            }

                        }   
                    } catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (opt > 7 || opt < 1);      
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Você escolheu a operação de Soma!");
                        do 
                        {
                            Num1 = true;
                            Num2 = true;
                            try 
                            {
                                Console.Write("Informe o primeiro número: ");
                                ler = Console.ReadLine();
                                contVirgula=0;
                                for (int i = 0; i < ler.Length; i++)
                                {
                                    int eNumero = ler[i];
                                    if (i==0 && (eNumero == 45 || eNumero == 43))
                                    {
                                    } else if ((eNumero <= 57 && eNumero >= 48) || eNumero == 44)
                                    {
                                        if (eNumero==44)
                                        {
                                            contVirgula++;
                                        }
                                        if (contVirgula > 1)
                                        {
                                            Num1 = false;
                                            throw new ArgumentException("O número só pode ter 1 vírgula para separar dos números dos decimais");
                                        }
                                    } else 
                                    {
                                        Num1 = false;
                                        throw new ArgumentException("Esse campo só pode receber valores numéricos");
                                    }
                                }
                                n1 = Convert.ToDouble(ler);
                                Console.Write("Informe o segundo número: ");
                                ler = Console.ReadLine();
                                contVirgula=0;
                                for (int i = 0; i < ler.Length; i++)
                                {
                                    int eNumero = ler[i];
                                    if (i==0 && (eNumero == 45 || eNumero == 43))
                                    {
                                    } else if ((eNumero <= 57 && eNumero >= 48) || eNumero == 44)
                                    {
                                        if (eNumero==44)
                                        {
                                            contVirgula++;
                                        }
                                        if (contVirgula > 1)
                                        {
                                            Num2 = false;
                                            throw new ArgumentException("O número só pode ter 1 vírgula para separar dos números dos decimais");
                                        }
                                    } else 
                                    {
                                        Num2 = false;
                                        throw new ArgumentException("Esse campo só pode receber valores numéricos");
                                    }
                                }
                                n2 = Convert.ToDouble(ler);
                                Calculadora soma = new Soma(n1,n2);
                                Console.WriteLine($"Resultado: {soma.Operacao()}");
                                historico.Add($"{n1} + {n2} = {soma.Operacao()}");
                                
                            } catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        } while (Num1 == false || Num2 == false);
                        
                    break;
                    case 2:
                        Console.WriteLine("Você escolheu a operação de Subtração!");
                        do 
                        {
                            Num1 = true;
                            Num2 = true;
                            try 
                            {
                                Console.Write("Informe o primeiro número: ");
                                ler = Console.ReadLine();
                                contVirgula=0;
                                for (int i = 0; i < ler.Length; i++)
                                {
                                    int eNumero = ler[i];
                                    if (i==0 && (eNumero == 45 || eNumero == 43))
                                    {
                                    } else if ((eNumero <= 57 && eNumero >= 48) || eNumero == 44)
                                    {
                                        if (eNumero==44)
                                        {
                                            contVirgula++;
                                        }
                                        if (contVirgula > 1)
                                        {
                                            Num1 = false;
                                            throw new ArgumentException("O número só pode ter 1 vírgula para separar dos números dos decimais");
                                        }
                                    } else 
                                    {
                                        Num1 = false;
                                        throw new ArgumentException("Esse campo só pode receber valores numéricos");
                                    }
                                }
                                n1 = Convert.ToDouble(ler);
                                Console.Write("Informe o segundo número: ");
                                ler = Console.ReadLine();
                                contVirgula=0;
                                for (int i = 0; i < ler.Length; i++)
                                {
                                    int eNumero = ler[i];
                                    if (i==0 && (eNumero == 45 || eNumero == 43))
                                    {
                                    } else if ((eNumero <= 57 && eNumero >= 48) || eNumero == 44)
                                    {
                                        if (eNumero==44)
                                        {
                                            contVirgula++;
                                        }
                                        if (contVirgula > 1)
                                        {
                                            Num2 = false;
                                            throw new ArgumentException("O número só pode ter 1 vírgula para separar dos números dos decimais");
                                        }
                                    } else 
                                    {
                                        Num2 = false;
                                        throw new ArgumentException("Esse campo só pode receber valores numéricos");
                                    }
                                }
                                n2 = Convert.ToDouble(ler);
                                Calculadora subtracao = new Subtracao(n1,n2);
                                Console.WriteLine($"Resultado: {subtracao.Operacao()}");
                                historico.Add($"{n1} - {n2} = {subtracao.Operacao()}");
                                
                            } catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        } while (Num1 == false || Num2 == false);
                        
                    break;
                    case 3:
                        Console.WriteLine("Você escolheu a operação de Divisão!");
                        do 
                        {
                            Num1 = true;
                            Num2 = true;
                            try 
                            {
                                Console.Write("Informe o primeiro número: ");
                                ler = Console.ReadLine();
                                contVirgula=0;
                                for (int i = 0; i < ler.Length; i++)
                                {
                                    int eNumero = ler[i];
                                    if (i==0 && (eNumero == 45 || eNumero == 43))
                                    {
                                    } else if ((eNumero <= 57 && eNumero >= 48) || eNumero == 44)
                                    {
                                        if (eNumero==44)
                                        {
                                            contVirgula++;
                                        }
                                        if (contVirgula > 1)
                                        {
                                            Num1 = false;
                                            throw new ArgumentException("O número só pode ter 1 vírgula para separar dos números dos decimais");
                                        }
                                    } else 
                                    {
                                        Num1 = false;
                                        throw new ArgumentException("Esse campo só pode receber valores numéricos");
                                    }
                                }
                                n1 = Convert.ToDouble(ler);
                                Console.Write("Informe o segundo número: ");
                                ler = Console.ReadLine();
                                contVirgula=0;
                                for (int i = 0; i < ler.Length; i++)
                                {
                                    int eNumero = ler[i];
                                    if (i==0 && (eNumero == 45 || eNumero == 43))
                                    {
                                    } else if ((eNumero <= 57 && eNumero >= 48) || eNumero == 44)
                                    {
                                        if (eNumero==44)
                                        {
                                            contVirgula++;
                                        }
                                        if (contVirgula > 1)
                                        {
                                            Num2 = false;
                                            throw new ArgumentException("O número só pode ter 1 vírgula para separar dos números dos decimais");
                                        }
                                    } else 
                                    {
                                        Num2 = false;
                                        throw new ArgumentException("Esse campo só pode receber valores numéricos");
                                    }
                                }
                                n2 = Convert.ToDouble(ler);
                                try 
                                {
                                    if (n2 <= 0)
                                    {
                                        Num2 = false;
                                        throw new DivideByZeroException("Não se pode dividir um número por zero ou um número negativo");
                                    }
                                } catch (DivideByZeroException e)
                                {
                                    Console.WriteLine(e.Message);
                                }

                                Calculadora divisao = new Divisao(n1,n2);
                                Console.WriteLine($"Resultado: {divisao.Operacao()}");
                                historico.Add($"{n1} / {n2} = {divisao.Operacao()}");

                            } catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        } while (Num1 == false || Num2 == false);

                    break;
                    case 4:
                        Console.WriteLine("Você escolheu a operação de Multiplicação!");
                        Console.Write("Informe o primeiro número: ");
                        ler = Console.ReadLine();
                        do 
                        {
                            Num1 = true;
                            Num2 = true;
                            try 
                            {
                                Console.Write("Informe o primeiro número: ");
                                ler = Console.ReadLine();
                                contVirgula=0;
                                for (int i = 0; i < ler.Length; i++)
                                {
                                    int eNumero = ler[i];
                                    if (i==0 && (eNumero == 45 || eNumero == 43))
                                    {
                                    } else if ((eNumero <= 57 && eNumero >= 48) || eNumero == 44)
                                    {
                                        if (eNumero==44)
                                        {
                                            contVirgula++;
                                        }
                                        if (contVirgula > 1)
                                        {
                                            Num1 = false;
                                            throw new ArgumentException("O número só pode ter 1 vírgula para separar dos números dos decimais");
                                        }
                                    } else 
                                    {
                                        Num1 = false;
                                        throw new ArgumentException("Esse campo só pode receber valores numéricos");
                                    }
                                }
                                n1 = Convert.ToDouble(ler);
                                Console.Write("Informe o segundo número: ");
                                ler = Console.ReadLine();
                                contVirgula=0;
                                for (int i = 0; i < ler.Length; i++)
                                {
                                    int eNumero = ler[i];
                                    if (i==0 && (eNumero == 45 || eNumero == 43))
                                    {
                                    } else if ((eNumero <= 57 && eNumero >= 48) || eNumero == 44)
                                    {
                                        if (eNumero==44)
                                        {
                                            contVirgula++;
                                        }
                                        if (contVirgula > 1)
                                        {
                                            Num2 = false;
                                            throw new ArgumentException("O número só pode ter 1 vírgula para separar dos números dos decimais");
                                        }
                                    } else 
                                    {
                                        Num2 = false;
                                        throw new ArgumentException("Esse campo só pode receber valores numéricos");
                                    }
                                }
                                n2 = Convert.ToDouble(ler);
                                Calculadora multiplicacao = new Multiplicacao(n1,n2);
                                Console.WriteLine($"Resultado: {multiplicacao.Operacao()}");
                                historico.Add($"{n1} * {n2} = {multiplicacao.Operacao()}");

                            } catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        } while (Num1 == false || Num2 == false);

                    break;
                    case 5:
                        Console.WriteLine("Você escolheu a operação de Potência Base 2!");
                        do 
                        {
                            Num1 = true;
                            try 
                            {
                                Console.Write("Informe o número que será elevado ao quadrado: ");
                                ler = Console.ReadLine();
                                contVirgula=0;
                                for (int i = 0; i < ler.Length; i++)
                                {
                                    int eNumero = ler[i];
                                    if (i==0 && (eNumero == 45 || eNumero == 43))
                                    {
                                    } else if ((eNumero <= 57 && eNumero >= 48) || eNumero == 44)
                                    {
                                        if (eNumero==44)
                                        {
                                            contVirgula++;
                                        }
                                        if (contVirgula > 1)
                                        {
                                            Num1 = false;
                                            throw new ArgumentException("O número só pode ter 1 vírgula para separar dos números dos decimais");
                                        }
                                    } else 
                                    {
                                        Num1 = false;
                                        throw new ArgumentException("Esse campo só pode receber valores numéricos");
                                    }
                                }
                                n1 = Convert.ToDouble(ler);
                                Calculadora potenciaB2 = new PotenciaBase2(n1,n2);
                                Console.WriteLine($"Resultado: {potenciaB2.Operacao()}");
                                historico.Add($"{n1} ^ 2 = {potenciaB2.Operacao()}");
                                
                            } catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        } while (Num1 == false);
                        
                    break;
                    case 6:
                        Console.WriteLine("Você escolheu a operação de Potência!");
                        do 
                        {
                            Num1 = true;
                            Num2 = true;
                            try 
                            {
                                Console.Write("Informe o número da base: ");
                                ler = Console.ReadLine();
                                contVirgula=0;
                                for (int i = 0; i < ler.Length; i++)
                                {
                                    int eNumero = ler[i];
                                    if (i==0 && (eNumero == 45 || eNumero == 43))
                                    {
                                    } else if ((eNumero <= 57 && eNumero >= 48) || eNumero == 44)
                                    {
                                        if (eNumero==44)
                                        {
                                            contVirgula++;
                                        }
                                        if (contVirgula > 1)
                                        {
                                            Num1 = false;
                                            throw new ArgumentException("O número só pode ter 1 vírgula para separar dos números dos decimais");
                                        }
                                    } else 
                                    {
                                        Num1 = false;
                                        throw new ArgumentException("Esse campo só pode receber valores numéricos");
                                    }
                                }
                                n1 = Convert.ToDouble(ler);
                                Console.Write("Informe o número da potência: ");
                                ler = Console.ReadLine();
                                contVirgula=0;
                                for (int i = 0; i < ler.Length; i++)
                                {
                                    int eNumero = ler[i];
                                    if (i==0 && (eNumero == 45 || eNumero == 43))
                                    {
                                    } else if ((eNumero <= 57 && eNumero >= 48) || eNumero == 44)
                                    {
                                        if (eNumero==44)
                                        {
                                            contVirgula++;
                                        }
                                        if (contVirgula > 1)
                                        {
                                            Num2 = false;
                                            throw new ArgumentException("O número só pode ter 1 vírgula para separar dos números dos decimais");
                                        }
                                    } else 
                                    {
                                        Num2 = false;
                                        throw new ArgumentException("Esse campo só pode receber valores numéricos");
                                    }
                                }
                                n2 = Convert.ToDouble(ler);
                                Calculadora potencia = new PotenciaBaseQualquer(n1,n2);
                                Console.WriteLine($"Resultado: {potencia.Operacao()}");
                                historico.Add($"{n1} ^ {n2} = {potencia.Operacao()}");

                            } catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        } while (Num1 == false || Num2 == false);

                    break;
                    case 7:
                        Console.Clear;
                        Console.WriteLine("Histórico de Operações: ");
                        for (int i = historico.Count-1; i >= 0; i--)
                        {
                            Console.WriteLine(historico[i]);
                        }
                    break;
                    default:
                        Console.WriteLine("A Opção informada não está disponível...");
                    break;
                }
                Console.WriteLine("Deseja fazer outra operação? Sim/Não");
                resposta = Console.ReadLine();
            } while (resposta.ToLower() == "sim");
        }
    }
}
