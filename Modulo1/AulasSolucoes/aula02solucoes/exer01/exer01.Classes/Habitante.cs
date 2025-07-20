using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer01.Classes
{
    public class Habitante
    {
        public string Nome {get;set;}
        public double Salario {get;set;}
        public int QtFilhos {get;set;}
        private static double MaiorSalario {get;set;}
        private static double MenorSalario {get;set;}
        private static double MediaSalarios {get;set;}
        public static int TotFilhos {get; private set;}
        private static int MediaQtFilhos {get;set;}
        public static int PessoasComMenosQueSalarioMinimo {get; private set;}
        public static double TotSalarios {get;private set;}
        private static int IDHabitante {get;set;}
        public Habitante (string nome, double salario, int qtFilhos)
        {
            Nome = nome;
            Salario = salario;
            QtFilhos = qtFilhos;
            IDHabitante++;
        }
        public void AcharMaiorSalario (Habitante habitante)
        {
            if (MaiorSalario < habitante.Salario)
            {
                MaiorSalario = habitante.Salario;
            }
        }
        public void AcharMenorSalario (Habitante habitante)
        {
            if (IDHabitante < 2)
            {
                MenorSalario = habitante.Salario;
            } else if (MenorSalario > habitante.Salario)
            {
                MenorSalario = habitante.Salario;
            }
        }
        public void AcharTotFilhos (Habitante habitante)
        {
            TotFilhos += habitante.QtFilhos;
        }
        public void AcharMediaQtFilhos ()
        {
            MediaQtFilhos = TotFilhos/IDHabitante;
        }
        public void AcharTotSalarios (Habitante habitante)
        {
            TotSalarios += habitante.Salario;
        }
        public void AcharMediaSalarios ()
        {
            MediaSalarios = TotSalarios/IDHabitante;
        }
        public void PessoasAbaixoDeSalarioMinimo (Habitante habitante)
        {
            if (habitante.Salario < 1320.00/2)
            {
                PessoasComMenosQueSalarioMinimo++;
            }
        }
        public string PercentualPessoasAbaixoDeSalarioMinimo ()
        {
            double percentual = PessoasComMenosQueSalarioMinimo*100/IDHabitante;
            string respostaPercentual = percentual.ToString("N2");
            return respostaPercentual;
        }
        public double  ExibirMediaSalarios()
        {
            return MediaSalarios;
        }
        public double ExibirMediaQtFilhos()
        {
            return MediaQtFilhos;
        }
        public double ExibirMaiorSalario()
        {
            return MaiorSalario;
        }
        public double ExibirMenorSalario()
        {
            return MenorSalario;    
        }
    }
}