using System;

namespace exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja inserir os dados coletados de um cidadão para o pré sensu? Sim/Não");
	    	var ler = Console.ReadLine();
            double menor = 0.0;
	    	double maior = 0.0;
            double total = 0.0;
	    	double mediasal = 0.0;
            int nsalabaixodemeio = 0;
            int npessoas = 0;
            int nfilhos = 0;
            int totalfilhos = 0;
            int mediafilhos = 0;
	    	ler = ler.ToLower();
            if (ler == "sim")
            {
                npessoas++;
                Console.WriteLine("Informe o salário do cidadão: R$ ");
                ler = Console.ReadLine();
                double salario = Convert.ToDouble(ler);
                maior = salario;
                menor = salario;
                total = somasal(total,salario);
                Console.WriteLine("Informe o número de filhos do cidadão: ");
                ler = Console.ReadLine();
                nfilhos = Convert.ToInt32(ler);
                totalfilhos = somarfilhos(totalfilhos,nfilhos);
                double nsalabaixodemeio1 = abaixomeiosal(nsalabaixodemeio,salario);
                nsalabaixodemeio = Convert.ToInt32(nsalabaixodemeio1);
                Console.WriteLine("Caso queira parar de inserir dados coletados para o pre sensu escreva: Sair, caso queira continuar pressione Enter");
	    	    ler = Console.ReadLine();
	    	    ler = ler.ToLower();
	    	    while (ler != "sair")
	    	    {
                    npessoas++;
                    Console.WriteLine("Informe o salário do cidadão: R$ ");
                    ler = Console.ReadLine();
                    salario = Convert.ToDouble(ler);
                    maior = maiorsal(maior,salario);
                    menor = menorsal(menor,salario);
                    total = somasal(total,salario);
                    Console.WriteLine("Informe o número de filhos do cidadão: ");
                    ler = Console.ReadLine();
                    nfilhos = Convert.ToInt32(ler);
                    totalfilhos = somarfilhos(totalfilhos,nfilhos);
                    nsalabaixodemeio1 = abaixomeiosal(nsalabaixodemeio,salario);
                    nsalabaixodemeio = Convert.ToInt32(nsalabaixodemeio1);
                    Console.WriteLine("Caso queira para de inserir dados coletados para o pre sensu escreva: Sair, caso queira continuar pressione Enter");
	    	        ler = Console.ReadLine();
	    	        ler = ler.ToLower();
                }
                double npessoas1 = Convert.ToDouble(npessoas);
                mediasal = media1(total,  npessoas1);
                mediafilhos = media2 (totalfilhos,npessoas);
                Console.WriteLine("A média salarial da  população é: R$ " + mediasal);
                Console.WriteLine("A média de filhos da população é: " + mediafilhos);
                Console.WriteLine("O maior salário informado foi: R$ " + maior);
                Console.WriteLine("O menor salário informado foi: R$ " + menor);
                nsalabaixodemeio1=Convert.ToDouble(nsalabaixodemeio);
                Console.WriteLine("O percentual de  pessoa com salário abaixo de meio salário mínimo é: " + npercentabaixodemeio(nsalabaixodemeio1, npessoas1) + "%");
            }
	    	
        }
	    static int somarfilhos (int v1, int v2)
	    {
		    v1=v1+v2;
		    return v1;
	    }
	    static double maiorsal (double v1, double v2)
	    {
	    	if (v1<v2)
	    	{
	    		v1=v2;
	    	}
	    	return v1;
	    }
    	static double menorsal (double v1, double v2)
    	{
	    	if (v1>v2)
    		{
    			v1=v2;
		    }
	    	return v1;
	    }
    	static double somasal (double v1, double v2)
    	{
    		v1 = v1 + v2;
            return v1;
    	}
        static double abaixomeiosal (double v1, double v2)
        {
            if (v2 < 606.0)
            {
                v1++;
            }
            return v1;
        }
    	static double media1 (double v1, double v2)
	    {
	    	v1=v1/v2;
            return v1;
     }
        static int media2 (int v1, int v2)
	    {
    	    v1=v1/v2;
            return v1;
       }
       static double npercentabaixodemeio (double v1,  double  v2)
       {
           v1 = v1/(v2/100);
           return v1;
        }
    }
}
