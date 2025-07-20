using System;

namespace infos
{
    class Program
    {
        public class Contato 
        {
            public string nome;
            public string telefone;
            public string endereco;
        }
        static void Main(string[] args)
        {
           /*const int idade = 0; 
           const int quantidadeTrabalhadores = 2;
           int tempodecontribuicao = 1;
           string [] nomes = new string [quantidadeTrabalhadores];
           int[,] tempo = new int [quantidadeTrabalhadores,2];
           for (int i = 0; i < quantidadeTrabalhadores; i++)
           {
            Console.Write("Digite o nome do trabalhador: ");
            nomes[i] = Console.ReadLine();

            Console.Write("Digite a idade do trabalhador: ");
            tempo[i,0] = int.Parse(Console.ReadLine());
            Console.Write("Digite o tempo de contribuição do trabalhador: ");
            tempo[i,tempodecontribuicao] = int.Parse(Console.ReadLine());
           }
           Console.WriteLine("Nome          Idade           Tempo           Situação");
           Console.WriteLine("----          -----           -----           --------");
           for (int i =0; i < quantidadeTrabalhadores; i++)
           {
                Console.Write($"{nomes[i]}    {tempo[i,idade]}    {tempo[i,tempodecontribuicao]}");
                if (tempo[i,idade] > 64)
                {
                    Console.Write($"    Sim");
                } else if (tempo [i,tempodecontribuicao] > 34)
                {
                    Console.Write($"    Sim");
                } else if (tempo[i,idade] > 59 && tempo[i,tempodecontribuicao] > 24)
                {
                    Console.Write($"    Sim");
                } else
                {
                    Console.Write($"    Não");
                }
                Console.WriteLine();
           }*/

           //argumento por referência Ex: int [] x = new int [int[10]];
           //argumento por valor Ex: int x = 10;
           /* Console.WriteLine("Informe o valor 1: ");*/
           /*int v1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Informe o valor 2: ");
           int v2 = int.Parse(Console.ReadLine());
           int resultadosoma = soma(v1,v2);
           int resultadomult = multiplicacao(v1,v2);
           int [] arrayinteiro = {10,30};
           subtrair(arrayinteiro);
           Console.WriteLine($"O resultado da soma de {v1} e {v2} é {resultadosoma}");
           Console.WriteLine($"O resultado da multiplicação de {v1} e {v2} é {resultadomult}");
           Console.WriteLine($"O resultado da subtração: {arrayinteiro[0]}"); //passaod por referência
            
            DateTime date = new DateTime(2023,4,25,8,10,11);
            var date2 = new DateTime(2000, 1, 15);
            var date3 = DateTime.Now; //HORÁRIO DO COMPUTADOR se for usado UtcNow vai ser o horário do meridiado de greenwich
            Console.WriteLine("Dia da semana: " + date.DayOfWeek);
            Console.WriteLine("Data e hora: " + date3);
           // CultureInfo idioma = new CultureInfo("pt-BR"); //informando que as informações do devem ser passadas no idioma pt-br
            */ 
            Contato c1 = new Contato();
            Console.WriteLine($"nome: {c1.nome} - telefone: {c1.telefone} - endereço: {c1.endereco}");
            c1.nome = "Não";
            c1.telefone = "11 1111";
            c1.endereco = "Rua";
            Console.WriteLine($"nome: {c1.nome} - telefone: {c1.telefone} - endereço: {c1.endereco}");

        }
        static int soma (int v1, int v2)
        {
            return (v1+v2);
        }
        static int multiplicacao (int v1, int v2)
        {
            return (v1*v2);
        }
        static void subtrair (int [] v1) //por ser void não retorna o valor
        { //mas o valor vai ser passado por referência mesmo assim
            v1 [0] = v1[0] - v1[1];
        }
    }
}
