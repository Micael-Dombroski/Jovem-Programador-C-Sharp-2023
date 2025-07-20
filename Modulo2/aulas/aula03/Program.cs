using System;

namespace aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------Revisão

            /*Console.WriteLine("Olá mundo!!!");
            Console.Write("Como vai todos vocês??");
            Console.Write("Espero que estejam bem!");*/

            /*Console.Write("Digite seu nome: ");
            var texto = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(texto);
            var chara = Console.Read();
            Console.WriteLine(chara);
            var tecla = Console.ReadKey();
            Console.WriteLine(tecla);*/

            /*bool variavel = true;
            Console.WriteLine(variavel);*/

            //Tipos de Dados
            //cada tipo de dado são guardados em partes específicas da memória

            //-Lógico (Tamanho 1bit): bool, retorna true ou false, 0 ou 1, ligado ou desligado

            /*-Inteiros
            Tipo           Intervalo           Tamanho
            sbyte          128 a 127           8 bits
            byte           0 a 255             8 bits
            short          -32.768 a 32.767    16 bits
            ushort         0 a 65.535          16 bits
            int            -2.147.483.648 a 2.147.483.647     32 bits
            uint           0 a 4.294.967.295   32 bits
            long           -9.223.372.036.854.775.808 a 9.223.372.036.854.775.07     64 bits
            ulong          0 a 18.446.744.073.709.551.615   64 bits
            */

            /*-Decimais
            decimal       1.0 x 10-28 a 7.9 x 1028     96 bits
            double        +- 5.0 x 10-324 a +-1.7 x 10308    64 bits
            float         +- 1.5 x 10-45 a +- 3.4 x 1038    32 bits 
            */

            /*-Texto
            char: caractere único ex: 't'
            string: "Palavra ou frases completas"*/

            //-Implícito: são variáveis que não possuem um tipo até a inicialização do código (famoso var)

            /*int inteiro = 10;
            double pontoFlutuante = 10.99;
            char caracter = 'a';
            string texto = "Palavras";
            var tipoImplicito = 2f;
            var stringAleatorio = Console.ReadLine();
            Console.WriteLine(caracter);
            Console.WriteLine(texto);
            Console.WriteLine(inteiro);
            Console.WriteLine(pontoFlutuante);
            Console.WriteLine(tipoImplicito);
            Console.WriteLine(stringAleatorio);*/

            /*var divisão = 3.0/2;
            Console.WriteLine(divisão);*/

            //Operadores aritméticos: +,-,*,/,%

            //Operadores reduzidos
            
            /*double x = 6;
            double y = 3;
            double resultado = 2;
            resultado += x;
            Console.WriteLine(resultado);
            resultado -= x;
            Console.WriteLine(resultado);
            resultado *= x;
            Console.WriteLine(resultado);
            resultado /= x;
            Console.WriteLine(resultado);
            resultado %= x;
            Console.WriteLine(resultado);*/

            //Incremento ++ e Decremento --

            /*double x = 6;
            Console.WriteLine(x++);//escreve a variável e dps incrementa seu valor
            Console.WriteLine(x);
            Console.WriteLine(++x);//incrementa o valor da variável e dps escreve ela

            double y = 3;
            Console.WriteLine(y--);//escreve a variável e dps decrecrementa seu valor
            Console.WriteLine(y);
            Console.WriteLine(--y);//decrementa o valor da variável e dps escreve ela
            */

            //Operadores Relacionais: São usados para fazerem comparações entre dois valores, sempre devolvem true ou false

            //== igual a
            //!= diferente de
            //> Maior que
            //< Menor que
            //>= Maior ou igual
            //<= Menor ou igual

            /*double x = 6;
            double y = 1;
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x <= y);
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);*/

            //Operadores Lógicos: Duas comparações são usadas para que esses operadores retornem true ou false
            //&& True e True = True
            //|| True e False = False
            //if True == False

            //Estruturas de Repetição: do while, for, foreach, while
            /*for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(i++);
            }*/
            
        }
    }
}
