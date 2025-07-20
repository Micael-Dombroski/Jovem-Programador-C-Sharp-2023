using System;

namespace exer04
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] dicionario = {"ola", "mundo", "boa tarde" , "boa noite"};
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
                            if (c+5 < tamanho-1)
                            {
                                c++;
                                palavra= $"{palavra}{text[c]}";
                                c++;
                                palavra= $"{palavra}{text[c]}";
                                c++;
                                palavra= $"{palavra}{text[c]}";
                                c++;
                                palavra= $"{palavra}{text[c]}";
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
                                } else
                                {
                                    c= c-5;
                                }
                            }
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
