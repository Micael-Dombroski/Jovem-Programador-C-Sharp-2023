using System;

namespace exer05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validacao = false;
            while (validacao == false)
            {
                Console.Write("Informe sua senha: ");
                string senha = Console.ReadLine();
                int qtNum = 0;
                int qtMaiusc = 0;
                int qtMinusc = 0;
                int qtCharEsp = 0;
                for (int i = 0; i < senha.Length; i++)
                {
                    int pDecimal = senha[i];
                    if ((pDecimal > 32 && pDecimal < 48) || (pDecimal > 57 && pDecimal < 65) || (pDecimal > 90 && pDecimal < 97))
                    {
                        qtCharEsp++;
                    }
                    if (pDecimal > 64 && pDecimal < 91)
                    {
                        qtMaiusc++;
                    }
                    if (pDecimal > 96 && pDecimal < 123)
                    {
                        qtMinusc++;
                    }
                    if (pDecimal > 47 && pDecimal < 58)
                    {
                        qtNum++;
                    }
                }
                if (senha.Length < 8)
                {
                    validacao = false;
                } else if (qtNum == 0)
                {
                    validacao = false;
                } else if (qtMaiusc == 0)
                {
                    validacao = false;
                } else if (qtMinusc == 0)
                {
                    validacao = false;
                } else if (qtCharEsp == 0)
                {
                    validacao = false;
                } else
                {
                    validacao = true;
                    Console.WriteLine($"Quantidade de Caracteres: {senha.Length}");
                    Console.WriteLine($"Quantidade de Letras Maiúsculas: {qtMaiusc}");
                    Console.WriteLine($"Quantidade de Letras Minúsculas: {qtMinusc}");
                    Console.WriteLine($"Quantidade de Números: {qtNum}");
                    Console.WriteLine($"Quantidade de Caracteres Especiais: {qtCharEsp}");
                }
                if (validacao == false)
                {
                    Console.WriteLine("A senha deve possuir no mínimo 8 caracteres sendo pelo menos 1 especial, 1 letra maiúscula, 1 letra minúscula e 1 número");
                }
            }
        }
    }
}
