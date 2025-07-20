using System;

namespace exer13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça seu cadastro:");
            Console.WriteLine("Insira seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Confirme seu nome:");
            string checknome = Console.ReadLine();
            while (nome !=  checknome)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O nome inserido está diferente do informado anteriormente...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Confirme seu nome:");
                checknome = Console.ReadLine();
            }
            Console.WriteLine("Crie uma senha: ");
            string senha = Console.ReadLine();
            Console.WriteLine("Confirme sua senha: ");
            string checksenha = Console.ReadLine();
            while (senha != checksenha)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A senha inserida está diferente da que foi informada anteriormente...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Confirme sua senha: ");
                checksenha = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Seu cadastro foi concluído com sucesso!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Deseja fazer seu login? S/N");
            string resposta = Console.ReadLine();
            bool logado = false;
            if (resposta == "S" || resposta == "s")
            {
                while (logado == false)
                {
                    Console.WriteLine("Informe seu nome: ");
                    checknome = Console.ReadLine();
                    Console.WriteLine("Informe sua senha: ");
                    checksenha = Console.ReadLine();
                    Console.WriteLine("Pressione Enter para efetuar seu login");
                    Console.ReadKey();
                    if (checknome != nome && checksenha != senha)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Usuário e senha não cadastrados...");
                        Console.ForegroundColor = ConsoleColor.White;
                    } else if (checknome != nome && checksenha == senha) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Usuário não cadastrado...");
                        Console.ForegroundColor = ConsoleColor.White;
                    } else if (checknome == nome && checksenha != senha) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Senha incorreta...");
                        Console.ForegroundColor = ConsoleColor.White;
                    } else {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Seu login foi efetuado com sucesso!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Olá ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(nome);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine(", seja bem-vindo(a)!");
                        logado = true;
                    }
                }
            } else {
                Console.WriteLine("Certo...Tenha um bom dia!");
            }
        }
    }
}
