using System;

namespace infos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*vetores são compostos pelo nome(do vetor), conteúdo e pelo índice
             (quantidade de espaços disponíveis)
             
            O array pode conter um conjunto de dados do mesmo tipo.
            
            int [] n = new int [2]; é o mesmo que int [] n = new int [2,3];

            */
            /*string [] dicionario = {"ola", "mundo", "boa tarde" , "boa noite"};
            Console.WriteLine("Escreva um texto: ");
            string text = Console.ReadLine();
            text = text.ToLower();
            Console.WriteLine(text);
            int tamanho = text.Length;
            Console.WriteLine(tamanho);
            //int decimalcarac = 0;
            string palavra ="";
            int npalavras = 0;
            for (int c = 0; c < tamanho; c++) 
            {
                palavra = $"{palavra}{text[c]}";
                int pos = c;
                if (palavra == "o" || palavra == "m" || palavra == "b")
                {
                    c++;
                    palavra= $"{palavra}{text[c]}";
                    c++;
                    palavra = $"{palavra}{text[c]}";
                    if (palavra == "ola")
                    {
                        Console.WriteLine("A palavra " + dicionario[0] + " está no dicionário!");
                        npalavras++;
                    } else if (palavra == "mun")
                    {
                        c++;
                        palavra= $"{palavra}{text[c]}";
                        c++;
                        palavra = $"{palavra}{text[c]}";
                        if (palavra == "mundo")
                        {
                            Console.WriteLine("A palavra " + dicionario[1] + " está no dicionário!");
                            npalavras++;
                        }
                    } else if (palavra == "boa")
                    {
                        c++;
                        palavra = $"{palavra}{text[c]}";
                        if (palavra == "boa ")
                        {
                            c++;
                            palavra= $"{palavra}{text[c]}";
                            c++;
                            palavra = $"{palavra}{text[c]}";
                            c++;
                            palavra= $"{palavra}{text[c]}";
                            c++;
                            palavra = $"{palavra}{text[c]}";
                            c++;
                            palavra = $"{palavra}{text[c]}";
                            if (palavra == "boa tarde")
                            {
                                Console.WriteLine("A palavra " + dicionario[2] + " está no dicionário!");
                                npalavras++;
                            } else if (palavra == "boa noite")
                            {
                                Console.WriteLine("A palavra " + dicionario[3] + " está no dicionário!");
                                npalavras++;
                            }
                        
                        }
                    }
                }
                c =  pos;
                palavra = "";
            }
            Console.WriteLine("O texto possui " + npalavras + " palavras presentes no dicionário!");
            
            /*Arrays bidimensionais (parecem tabelas): int [,] n = new int [10,3]; [linhas, colunas]
            */
            /*const int linha = 3;
            const int coluna = 3;
            string [,] agenda = new string[linha, coluna];
            for (int i = 0; i < linha; i++)
            {
                Console.WriteLine("Informe o nome do contato: ");
                agenda[i,0] = Console.ReadLine();
                Console.WriteLine("Informe o telefone do contato: ");
                agenda[i,1] = Console.ReadLine();
                Console.WriteLine("Informe o endereço do contato: ");
                agenda[i,2] = Console.ReadLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("nome - telefone - endereço");
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write(agenda[i,j]);
                    Console.Write(" - ");
                }
                Console.WriteLine("\n");*/
                /*Console.WriteLine("IBGE");
                double salario = 0.0;
                double somasalarios = 0.0;
                double maiorsalario = 0.0;
                double menorsalario = 10000000.0;
                int abaixomeiosalario = 0;
                int npessoas = 0;
                int qtfilhos = 0;
                int nfilhos = 0;
                Console.WriteLine("Deseja cadastrar os daodos de uma pessoa no IBGE? S/N");
                var ler = Console.ReadLine();
                while (ler == "S" || ler == "s")
                {
                    npessoas++;
                    Console.WriteLine("Informe o saário da pessoa: ");
                    ler = Console.ReadLine();
                    salario = Convert.ToDouble(ler);
                    somasalarios += salario;
                    Console.WriteLine("Quantos filhos essa pessoa tem?");
                    ler = Console.ReadLine();
                    nfilhos = Convert.ToInt32(ler);
                    qtfilhos += nfilhos;
                    
                    if (maiorsalario < salario)
                    {
                        maiorsalario = salario;
                    }
                    if (menorsalario > salario)
                    {
                        menorsalario = salario;
                    }
                    if (salario <= 1818.0)
                    {
                        abaixomeiosalario++;
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Deseja cadastrar os daodos de outra pessoa no IBGE? S/N");
                    ler = Console.ReadLine();
                }
                Console.WriteLine("\n");
                double mediasalario = somasalarios/npessoas;
                double qtpessoas = Convert.ToDouble(npessoas);                
                Console.WriteLine("O número de pessoas registradas foi " + npessoas);
                Console.WriteLine("A média salarial é  R$ " + mediasalario);
                Console.WriteLine("A média de filhos é " + (qtfilhos/npessoas));
                Console.WriteLine("O maior salário informado foi R$ " + maiorsalario);
                Console.WriteLine("O menor salário informado foi R$ " + menorsalario);
                Console.WriteLine("A % de pessoas que recebem abaixo de 1.5 salários mínimos é " + (abaixomeiosalario/(qtpessoas/100)) + "%.");*/
            /*Console.WriteLine("Quantos funcionários solicitaram aposentadoria?");
            var ler = Console.ReadLine();
            int n = Convert.ToInt32(ler);
            string [] nome = new string [n];
            int [] idade = new int [n];
            int [] anostrabalhados = new int [n];
            string [] vaiaposentar = new string [n];
            for (int c = 0; c < n; c++)
            {
                Console.Write("Informe o nome do Funcionário: ");
                ler = Console.ReadLine();
                nome[c] = ler;
                Console.WriteLine("");
                Console.Write("Informe a idade do Funcionário: ");
                ler = Console.ReadLine();
                idade[c] = Convert.ToInt32(ler);;
                Console.WriteLine("");
                Console.Write("Informe os anos trabalhados do Funcionário: ");
                ler = Console.ReadLine();
                anostrabalhados[c] = Convert.ToInt32(ler);
                Console.WriteLine("");
                int ano = idade[c];
                int anotb = anostrabalhados[c];
                if (ano >= 65 || anotb >= 35)
                {
                    vaiaposentar[c] = "Sim";
                } else if (ano >= 60 && anotb >= 25)
                {
                    vaiaposentar[c] = "Sim";
                } else {
                    vaiaposentar[c] = "Não";
                }
            }
            Console.WriteLine("Relatório...");
            Console.WriteLine("Nome          Idade          Tempo          Situação");
            Console.WriteLine("----          -----          -----          --------");
            for (int c = 0; c < n; c++)
            {
                    Console.Write(nome[c]);
                    Console.Write("        ");
                    Console.Write(idade[c] + " anos");
                    Console.Write("     ");
                    Console.Write(anostrabalhados[c] + " anos");
                    Console.Write("             ");
                    Console.WriteLine(vaiaposentar[c]);
            }*/

        }
    }
}
