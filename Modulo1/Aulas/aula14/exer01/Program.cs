using System;

namespace exer01
{
    class Program
    {
        public static int index = 0;
        public static Aluno [] alunos = new Aluno [0];
        static void Main(string[] args)
        {      
            int resposta = 0;
            do 
            {
                switch (Menu())
                {
                    case 1:
                        NovoAluno();
                    break;
                    case 2:
                        EditarAluno();
                    break;
                    case 3:
                        ConsultarAluno();
                    break;
                    case 4:
                        ExcluirAluno();
                    break;
                    case 5:
                        ExibirTodos();
                    break;
                    case 6:
                        resposta = 1;
                        Console.WriteLine("Saindo...");
                    break;
                    default:
                        Console.WriteLine("A opção escolhida  não está disponível...");
                    break;
                }
            } while (resposta < 1);
        }
        static int Menu()
        {
            Console.WriteLine("-----------------Menu-----------------");
            Console.WriteLine("1-Novo Aluno");
            Console.WriteLine("2-Editar Aluno");
            Console.WriteLine("3-Consultar Aluno");
            Console.WriteLine("4-Deletar Aluno");
            Console.WriteLine("5-Mostrar todos os Alunos");
            Console.WriteLine("6-Sair do Sistema");
            Console.WriteLine("--------------------------------------");
            Console.Write("Digite o número da opção desejada: ");
            string ler = Console.ReadLine();
            Console.WriteLine();
            int opt = Convert.ToInt32(ler);
            return opt;
        }
        static void NovoAluno()
        {
            int matricula = index+1;
            Console.Write("Informe o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a primeira Nota do aluno: ");
            string ler = Console.ReadLine();
            double nota1 = Convert.ToDouble(ler);
            while (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("3RR0R: A nota informada não pode ser menor que 0 ou maior que 10...");
                Console.Write("Informe a primeira Nota do aluno: ");
                ler = Console.ReadLine();
                nota1 = Convert.ToDouble(ler);
            }
            Console.Write("Informe a segunda Nota do aluno: ");
            ler = Console.ReadLine();
            double nota2 = Convert.ToDouble(ler);
            while (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("3RR0R: A nota informada não pode ser menor que 0 ou maior que 10...");
                Console.Write("Informe a segunda Nota do aluno: ");
                ler = Console.ReadLine();
                nota2 = Convert.ToDouble(ler);
            }
            Console.Write("Informe a terceira Nota do aluno: ");
            ler = Console.ReadLine();
            double nota3 = Convert.ToDouble(ler);
            while (nota3 < 0.0 || nota3 > 10.0)
            {
                Console.WriteLine("3RR0R: A nota informada não pode ser menor que 0 ou maior que 10...");
                Console.Write("Informe a terceira Nota do aluno: ");
                ler = Console.ReadLine();
                nota3 = Convert.ToDouble(ler);
            }
            Console.Write("Informe a quarta Nota do aluno: ");
            ler = Console.ReadLine();
            double nota4 = Convert.ToDouble(ler);            
            while (nota4 < 0.0 || nota4 > 10.0)
            {
                Console.WriteLine("3RR0R: A nota informada não pode ser menor que 0 ou maior que 10...");
                Console.Write("Informe a quarta Nota do aluno: ");
                ler = Console.ReadLine();
                nota4 = Convert.ToDouble(ler); 
            }
            double media = (nota1+nota2+nota3+nota4)/4;
            string situacao = "";
            if (media >=7)
            {
                situacao = "Aprovado";
            } else if (media >= 5)
            {
                situacao = "Em Recuperação";
            } else
            {
                situacao = "Reprovado";
            }
            var aluno = new Aluno(matricula,nome,nota1,nota2,nota3,nota4,media,situacao);
            Aluno [] alunosTemp = new Aluno[alunos.Length+1];
            for (int i = 0; i < alunos.Length; i++)
            {
                alunosTemp[i] = alunos[i];
            }
            alunos = alunosTemp;
            alunos[index] = aluno;
            index++;
        }
        static void EditarAluno()
        {
            Console.Write("Informe a matrícula do Aluno que deseja editar: ");
            string ler = Console.ReadLine();
            int editar = Convert.ToInt32(ler);
            Console.WriteLine();
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i].Matricula == editar)
                {
                    Console.WriteLine("Deseja editar o nome do Aluno? Sim/Não");
                    ler=Console.ReadLine();
                    if (ler.ToLower() == "sim")
                    {
                        Console.Write("Informe a novo Nome do aluno: ");
                        alunos[i].Nome = Console.ReadLine();
                    }
                    Console.WriteLine("Deseja editar primeira nota do Aluno? Sim/Não");
                    ler=Console.ReadLine();
                    if (ler.ToLower() == "sim")
                    {
                        Console.Write("Informe a nova Nota do aluno: ");
                        ler = Console.ReadLine();
                        alunos[i].Nota1=Convert.ToDouble(ler);
                        while (alunos[i].Nota1 < 0.0 || alunos[i].Nota1 > 10.0)
                        {
                            Console.WriteLine("3RR0R: A nota informada não pode ser menor que 0 ou maior que 10...");
                            Console.Write("Informe a nova Nota do aluno: ");
                            ler = Console.ReadLine();
                            alunos[i].Nota1 = Convert.ToDouble(ler); 
                        }
                    }
                    Console.WriteLine("Deseja editar segunda nota do Aluno? Sim/Não");
                    ler=Console.ReadLine();
                    if (ler.ToLower() == "sim")
                    {
                        Console.Write("Informe a nova Nota do aluno: ");
                        ler = Console.ReadLine();
                        alunos[i].Nota2=Convert.ToDouble(ler);
                        while (alunos[i].Nota2 < 0.0 || alunos[i].Nota2 > 10.0)
                        {
                            Console.WriteLine("3RR0R: A nota informada não pode ser menor que 0 ou maior que 10...");
                            Console.Write("Informe a nova Nota do aluno: ");
                            ler = Console.ReadLine();
                            alunos[i].Nota2 = Convert.ToDouble(ler); 
                        }
                    }
                    Console.WriteLine("Deseja editar terceira nota do Aluno? Sim/Não");
                    ler=Console.ReadLine();
                    if (ler.ToLower() == "sim")
                    {
                        Console.Write("Informe a nova Nota do aluno: ");
                        ler = Console.ReadLine();
                        alunos[i].Nota3=Convert.ToDouble(ler);
                        while (alunos[i].Nota3 < 0.0 || alunos[i].Nota3 > 10.0)
                        {
                            Console.WriteLine("3RR0R: A nota informada não pode ser menor que 0 ou maior que 10...");
                            Console.Write("Informe a nova Nota do aluno: ");
                            ler = Console.ReadLine();
                            alunos[i].Nota3 = Convert.ToDouble(ler); 
                        }
                    }
                    Console.WriteLine("Deseja editar quarta nota do Aluno? Sim/Não");
                    ler=Console.ReadLine();
                    if (ler.ToLower() == "sim")
                    {
                        Console.Write("Informe a nova Nota do aluno: ");
                        ler = Console.ReadLine();
                        alunos[i].Nota4=Convert.ToDouble(ler);
                        while (alunos[i].Nota4 < 0.0 || alunos[i].Nota4 > 10.0)
                        {
                            Console.WriteLine("3RR0R: A nota informada não pode ser menor que 0 ou maior que 10...");
                            Console.Write("Informe a nova Nota do aluno: ");
                            ler = Console.ReadLine();
                            alunos[i].Nota4 = Convert.ToDouble(ler); 
                        }
                    }
                    alunos[i].Media = (alunos[i].Nota1+alunos[i].Nota2+alunos[i].Nota3+alunos[i].Nota4)/4;
                    if (alunos[i].Media >=7)
                    {
                        alunos[i].Situacao = "Aprovado";
                    } else if (alunos[i].Media >= 5)
                    {
                        alunos[i].Situacao = "Em Recuperação";
                    } else
                    {
                        alunos[i].Situacao = "Reprovado";
                    }
                } else if (i==index)
                {
                    Console.WriteLine("Não há nenhum aluno no nosso sistema com essa matrícula...");
                }
            }
        }
        static void ConsultarAluno()
        {
            Console.Write("Informe a matrícula do Aluno que deseja consultar: ");
            string ler = Console.ReadLine();
            int consultar = Convert.ToInt32(ler);
            Console.WriteLine();
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i].Matricula == consultar)
                {
                    Console.WriteLine($"Número da Matrícula: {alunos[i].Matricula}");
                    Console.WriteLine($"Nome do Aluno: {alunos[i].Nome}");
                    Console.WriteLine($"Nota 1: {alunos[i].Nota1}");
                    Console.WriteLine($"Nota 2: {alunos[i].Nota2}");
                    Console.WriteLine($"Nota 3: {alunos[i].Nota3}");
                    Console.WriteLine($"Nota 4: {alunos[i].Nota4}");
                    Console.WriteLine($"Média do Aluno: {alunos[i].Media}");
                    Console.WriteLine($"Situação do Aluno: {alunos[i].Situacao}");
                } else if (i==index)
                {
                    Console.WriteLine("Não há nenhum aluno no nosso sistema com essa matrícula...");
                }
            }
        }
        static void ExcluirAluno()
        {
            Console.Write("Informe a matrícula do Aluno que deseja excluir: ");
            string ler = Console.ReadLine();
            int excluir = Convert.ToInt32(ler);
            Console.WriteLine();
            int v=0;
            for (int i = 0; i < alunos.Length; i++)
            {
                if (excluir == alunos[i].Matricula)
                {
                    Console.WriteLine("Tem certeza que deseja excluir esse aluno? Sim/Não");
                    ler=Console.ReadLine();
                    if (ler.ToLower()=="sim")
                    {
                        Aluno [] alunosTemp = new Aluno [alunos.Length-1];
                        for (int j = 0; j < index-1; j++)
                        {
                            if (excluir == alunos[j].Matricula)
                            {
                                v=1;
                            }
                            if (v < 1)
                            {
                                alunosTemp[j] = alunos[j];
                            } else
                            {
                                alunosTemp[j] = alunos[j+1];
                            }
                        }
                        alunos = alunosTemp;
                        index--;
                        if (index > 0)
                        {
                            index = 0;
                        }
                    }
                }
            }
        }
        static void  ExibirTodos()
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine($"Número da Matrícula: {alunos[i].Matricula}");
                Console.WriteLine($"Nome do Aluno: {alunos[i].Nome}");
                Console.WriteLine($"Nota 1: {alunos[i].Nota1}");
                Console.WriteLine($"Nota 2: {alunos[i].Nota2}");
                Console.WriteLine($"Nota 3: {alunos[i].Nota3}");
                Console.WriteLine($"Nota 4: {alunos[i].Nota4}");
                Console.WriteLine($"Média do Aluno: {alunos[i].Media}");
                Console.WriteLine($"Situação do Aluno: {alunos[i].Situacao}");
                Console.WriteLine();
            }
        }
    }
}
