using System;

namespace exer02
{
    class Program
    {
        static void Main(string[] args)
        {
            double quadradoA = 0.0;
            double retanguloA = 0.0;
            double  trianguloA = 0.0;
            string ler = "";
            int [] respostas = new int [3];
            int i = 0;
            do {
                Console.WriteLine("De qual você deseja calcular a área primeiro?");
                Console.WriteLine("1 - Quadrado");
                Console.WriteLine("2 - Retânguloo");
                Console.WriteLine("3 - Triângulo");
                Console.Write("Informe a opção desejada através do seu respectivo número: ");
                ler = Console.ReadLine();
                Console.WriteLine();
                int resposta = Convert.ToInt32(ler);
                respostas[i] = resposta;
                i++;
                for (int c = 0; c < i; c++)
                {
                    if (respostas [c] == respostas [i-1] && c != i-1)
                    {
                        Console.WriteLine("A opção já foi escolhida anteriormente. Escolha uma opção que ainda não tenha sido escolhida...");
                        ler = Console.ReadLine();
                        resposta = Convert.ToInt32(ler);
                        c = 0;
                        respostas [i-1] = resposta;
                    }
                }
                switch (resposta)
                {
                    case 1:
                        var quadrado = new AreaQuadrado();
                        Console.Write("Informe a medida de uma dos lados do quadrado (Ex: 11,1): ");
                        ler = Console.ReadLine();
                        quadrado.Lado = Convert.ToDouble(ler);
                        while (quadrado.Lado <= 0.0)
                        {
                            Console.WriteLine("O valor não pode ser negativo ou igual a zero...");
                            Console.Write("Informe a medida de uma dos lados do quadrado (Ex: 11,1): ");
                            ler = Console.ReadLine();
                            quadrado.Lado = Convert.ToDouble(ler);
                        }
                        Console.WriteLine("Deseja  ver a área do quadrado agora? S/N");
                        ler = Console.ReadLine();
                        if (ler.ToLower() == "s")
                        {
                            Console.WriteLine($"A área do quadrado é {quadrado.CalcularAreaQuadrado(quadrado.Lado)}.");
                            quadradoA = quadrado.CalcularAreaQuadrado(quadrado.Lado);
                        } else
                        {
                            quadradoA = quadrado.CalcularAreaQuadrado(quadrado.Lado);
                        }
                    break;
                    case 2:
                        var retangulo = new AreaRetangulo();
                        Console.Write("Informe a medida da base do retângulo (Ex: 22,2): ");
                        ler = Console.ReadLine();
                        retangulo.Base = Convert.ToDouble(ler);
                        while (retangulo.Base <=  0.0)
                        {
                            Console.WriteLine("O valor não pode ser negativo ou igual a zero...");
                            Console.Write("Informe a medida da base do retângulo (Ex: 22,2): ");
                            ler = Console.ReadLine();
                            retangulo.Base = Convert.ToDouble(ler);
                        }
                        Console.Write("Informe a medida da altura do retângulo (Ex: 22,2): ");
                        ler = Console.ReadLine();
                        retangulo.Altura = Convert.ToDouble(ler);
                        while (retangulo.Altura <= 0.0)
                        {
                            Console.WriteLine("O valor não pode ser negativo ou igual a zero...");
                            Console.Write("Informe a medida da base do retângulo (Ex: 22,2): ");
                            ler = Console.ReadLine();
                            retangulo.Altura = Convert.ToDouble(ler);
                        }
                        Console.WriteLine("Deseja ver a área do retângulo agora? S/N");
                        ler = Console.ReadLine();
                        if (ler.ToLower() == "s")
                        {
                            Console.WriteLine($"A área do retângulo é {retangulo.CalcularAreaRetangulo(retangulo.Base,retangulo.Altura)}.");
                            retanguloA = retangulo.CalcularAreaRetangulo(retangulo.Base,retangulo.Altura);
                        } else
                        {
                            retanguloA = retangulo.CalcularAreaRetangulo(retangulo.Base,retangulo.Altura);
                        }
                    break;
                    case 3:
                        var triangulo = new AreaTriangulo();
                        Console.Write("Informe a medida da base do triângulo (Ex: 33,3): ");
                        ler = Console.ReadLine();
                        triangulo.Base = Convert.ToDouble(ler);
                        while (triangulo.Base <= 0.0)
                        {
                            Console.WriteLine("O valor não pode ser negativo ou igual a zero...");
                            Console.Write("Informe a medida da base do retângulo (Ex: 33,3): ");
                            ler = Console.ReadLine();
                            triangulo.Base = Convert.ToDouble(ler);
                        }
                        Console.Write("Informe a medida da altura do triângulo (Ex: 33,3): ");
                        ler = Console.ReadLine();
                        triangulo.Altura = Convert.ToDouble(ler);
                        while (triangulo.Altura <= 0.0)
                        {
                            Console.WriteLine("O valor não pode ser negativo ou igual a zero...");
                            Console.Write("Informe a medida da altura do retângulo (Ex: 33,3): ");
                            ler = Console.ReadLine();
                            triangulo.Altura = Convert.ToDouble(ler);
                        }
                        Console.WriteLine("Deseja ver a área do triângulo agora? S/N");
                        ler = Console.ReadLine();
                        if (ler.ToLower() == "s")
                        {
                            Console.WriteLine($"A área do triângulo é {triangulo.CalcularAreaTriangulo(triangulo.Base,triangulo.Altura)}.");
                            trianguloA = triangulo.CalcularAreaTriangulo(triangulo.Base,triangulo.Altura);
                        } else
                        {
                            trianguloA = triangulo.CalcularAreaTriangulo(triangulo.Base,triangulo.Altura);    
                        }
                    break;
                    default:
                        Console.WriteLine("A opção escolhida não existe...");
                        i--;
                    break;
                }
                Console.WriteLine("Para sair escreva Sair:");
                ler = Console.ReadLine();
            } while (ler.ToLower() != "sair");
            if (quadradoA == 0.0 && retanguloA == 0.0 && retanguloA == 0.0)
            {
                Console.WriteLine("Nenhuma área foi calculada...");
            } else 
            {
                Console.WriteLine("Abaixo estão as áreas calculadas:");
                if (quadradoA > 0.0)
                {
                    Console.WriteLine($"A área do quadrado é {quadradoA}.");
                } else 
                {
                    Console.WriteLine("Você optou por não calcular a área do quadrado...");
                }
                if (retanguloA > 0.0)
                {
                    Console.WriteLine($"A área do retângulo é {retanguloA}.");
                } else 
                {
                    Console.WriteLine("Você optou por não calcular a área do retângulo...");
                }
                if (trianguloA > 0.0)
                {
                    Console.WriteLine($"A área do triângulo é {trianguloA}.");
                } else 
                {
                    Console.WriteLine("Você optou por não calcular a área do triângulo...");
                }
            }

        }
    }
}
