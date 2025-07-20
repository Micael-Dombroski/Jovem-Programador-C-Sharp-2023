using System;

namespace aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            //BD é onde armazenamos todo o tipo de informação
            //sejam elas indexadas ou não

            /*
                Tipos de BD: Indexado (baseado em campos, tabelas e index)
                Árvore (possui uma estrutura semelhante a uma árvore, possui camadas)
                Orientado a Objetos (semelhante a um gráfico)
                NoSQL (semelhante ao Indexado mas é mais abundante)
            */

            /*
                SGBD: Conforme os BD cresciam veio a necessidade de gerenciar
                os dados, por isso foram desenvolvidos Sistemas Gerenciadores de BD

            */

            /*
                SQL: Principal BD Indexado da atualidade
            */

            /*
                Tipos de Dado: 
                    Numéricos(Inteiros, Ponto Flutuante)
                    Texto(VARCHAR, CHAR)
                    Data (Date, DateTime)
                    Binário/BLOB (armazena qualquer coisa, bastando converter
                        para binários, dados muito grandes são armazenados em formato 
                        de BLOB)
                    Boolean (Bool [True, False], Bit [0,1])

                    BLOB = Binary Large OBject
            */

            Console.WriteLine("Hello World!");
        }
    }
}
