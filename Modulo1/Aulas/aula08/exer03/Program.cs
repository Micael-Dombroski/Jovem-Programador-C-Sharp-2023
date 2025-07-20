using System;

namespace exer03
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "A única constante é a mudança";
            int tamanho = frase.Length;
            string [] palavras = new string [6];
            int pos = 0;
            int letracod = 0;
            for (int c = 0; c < tamanho; c++)
            {
                letracod = frase[c];
                if (letracod != 32)
                {
                    palavras[pos] = $"{palavras[pos]}{frase[c]}";
                } else {
                    pos++;
                }
            }
            for (int c = 0; c < 6; c++)
            {
                Console.WriteLine(palavras[c]);
            }
            
        }
    }
}
