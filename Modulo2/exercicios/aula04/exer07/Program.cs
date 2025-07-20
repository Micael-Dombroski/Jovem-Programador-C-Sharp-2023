using System;

namespace exer07
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] dicionario = {"ola", "mundo", "boa tarde" , "boa noite", "programador", "jovem", "goku", "bulma", "jujutsu", "sukuna"};
            Console.WriteLine("Escreva um texto: ");
            string text = Console.ReadLine();
            text = text.ToLower();
            Console.WriteLine(text);
            int tamanho = text.Length;
            Console.WriteLine(tamanho);
            string palavra ="";
            int npalavras = 0;
            for (int c = 0; c < tamanho; c++) 
            {
                palavra = $"{palavra}{text[c]}";
                int pos = c;
                if (palavra == "o")
                {
                    if (c+2 < tamanho)
                    {
                        palavra = $"{palavra}{text[c+1]}";
                        palavra = $"{palavra}{text[c+2]}";
                        if (palavra == "ola")
                        {
                            Console.WriteLine("A palavra " + dicionario[0] + " está no dicionário!");
                            npalavras++;
                        }
                    }
                } else if (palavra == "m")
                {
                    if (c+4 < tamanho)
                    {
                        palavra = $"{palavra}{text[c+1]}";
                        palavra = $"{palavra}{text[c+2]}";
                        palavra = $"{palavra}{text[c+3]}";
                        palavra = $"{palavra}{text[c+4]}";
                        if (palavra == "mundo")
                        {
                            Console.WriteLine("A palavra " + dicionario[1] + " está no dicionário!");
                            npalavras++;
                        }
                    }

                } else if (palavra == "b")
                {
                    if (c+1 < tamanho)
                    {
                        palavra = $"{palavra}{text[c+1]}";
                        if (palavra == "bo")
                        {
                            if (c+7 < tamanho)
                            {
                                palavra = $"{palavra}{text[c+2]}";
                                palavra = $"{palavra}{text[c+3]}";
                                palavra = $"{palavra}{text[c+4]}";
                                palavra = $"{palavra}{text[c+5]}";
                                palavra = $"{palavra}{text[c+6]}";
                                palavra = $"{palavra}{text[c+7]}";
                                palavra = $"{palavra}{text[c+8]}";
                                if (palavra == "boa tarde")
                                {
                                    Console.WriteLine("A palavra " + dicionario[2] + " está no dicionário!");
                                    npalavras++;
                                }
                                else if (palavra == "boa noite")
                                {
                                    Console.WriteLine("A palavra " + dicionario[3] + " está no dicionário!");
                                    npalavras++;
                                }
                            }
                        } else if (palavra == "bu")
                        {
                            if (c+3 < tamanho)
                            {
                                palavra = $"{palavra}{text[c+2]}";
                                palavra = $"{palavra}{text[c+3]}";
                                palavra = $"{palavra}{text[c+4]}";
                                if (palavra == "bulma")
                                {
                                    Console.WriteLine("A palavra " + dicionario[7] + " está no dicionário!");
                                    npalavras++;
                                }
                            }
                        }
                    }
                } else if (palavra == "p")
                {
                    if (c+10 < tamanho)
                    {
                        palavra = $"{palavra}{text[c+1]}";
                        palavra = $"{palavra}{text[c+2]}";
                        palavra = $"{palavra}{text[c+3]}";
                        palavra = $"{palavra}{text[c+4]}";
                        palavra = $"{palavra}{text[c+5]}";
                        palavra = $"{palavra}{text[c+6]}";
                        palavra = $"{palavra}{text[c+7]}";
                        palavra = $"{palavra}{text[c+8]}";
                        palavra = $"{palavra}{text[c+9]}";
                        palavra = $"{palavra}{text[c+10]}";
                        if (palavra == "programador")
                        {
                            Console.WriteLine("A palavra " + dicionario[4] + " está no dicionário!");
                            npalavras++;
                        }
                    }
                } else if (palavra == "j")
                {
                    if (c+4 < tamanho)
                    {
                        palavra = $"{palavra}{text[c+1]}";
                        palavra = $"{palavra}{text[c+2]}";
                        palavra = $"{palavra}{text[c+3]}";
                        palavra = $"{palavra}{text[c+4]}";
                        if (palavra == "jovem")
                        {
                            Console.WriteLine("A palavra " + dicionario[5] + " está no dicionário!");
                            npalavras++;
                        } else if (palavra == "jujut")
                        {
                            if (c+2 < tamanho)
                            {
                                palavra = $"{palavra}{text[c+5]}";
                                palavra = $"{palavra}{text[c+6]}";
                                if (palavra == "jujutsu")
                                {
                                    Console.WriteLine("A palavra " + dicionario[8] + " está no dicionário!");
                                    npalavras++;
                                }
                            }
                        }
                    }
                } else if (palavra == "g")
                {
                    if (c+3 < tamanho)
                    {
                        palavra = $"{palavra}{text[c+1]}";
                        palavra = $"{palavra}{text[c+2]}";
                        palavra = $"{palavra}{text[c+3]}";
                        if (palavra == "goku")
                        {
                            Console.WriteLine("A palavra " + dicionario[6] + " está no dicionário!");
                            npalavras++;
                        }
                    }
                } else if (palavra == "s")
                {
                    if (c+5 < tamanho)
                    {
                        palavra = $"{palavra}{text[c+1]}";
                        palavra = $"{palavra}{text[c+2]}";
                        palavra = $"{palavra}{text[c+3]}";
                        palavra = $"{palavra}{text[c+4]}";
                        palavra = $"{palavra}{text[c+5]}";
                        if (palavra == "sukuna")
                        {
                            Console.WriteLine("A palavra " + dicionario[9] + " está no dicionário!");
                            npalavras++;
                        }
                    }
                }
                c =  pos;
                palavra = "";
            }
            Console.WriteLine("O texto possui " + npalavras + " palavras presentes no dicionário!");
        }
    }
}
