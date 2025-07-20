using System;
using System.Globalization;

namespace exer02
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now;
            CultureInfo idioma = new CultureInfo("pt-BR");
            Console.Write("Lages, " + data.Day + " de " + idioma.DateTimeFormat.GetMonthName(data.Month) + " de " + data.Year + ". ");
            Console.Write("Hoje é " + idioma.DateTimeFormat.GetDayName(data.DayOfWeek) + " as ");
            Console.WriteLine(data.ToLongTimeString()+"\n");
            int mes = data.Month;
            int semana = Convert.ToInt32(data.DayOfWeek);
            string mesporextenso = "";
            string semanaporextenso = "";
            switch (mes)
            {
                case 1:
                    mesporextenso = "Janeiro";
                break;
                case 2:
                    mesporextenso = "Fevereiro";                   
                break;
                case 3:
                    mesporextenso = "Março";
                break;
                case 4:
                    mesporextenso = "Abril";
                break;
                case 5:
                    mesporextenso = "Maio";
                break;
                case 6:
                    mesporextenso = "Junho";
                break;
                case 7:
                    mesporextenso = "Julh";
                break;
                case 8:
                    mesporextenso = "Agosto";
                break;
                case 9:
                    mesporextenso = "Setembro";
                break;
                case 10:
                    mesporextenso = "Outubro";
                break;
                case 11:
                    mesporextenso = "Novembro";
                break;
                default:
                    mesporextenso = "Dezembro";
                break;
            }
            switch (semana)
            {
                case 1:
                    semanaporextenso="segunda-feira";
                break;
                case 2:
                    semanaporextenso="terça-feira";
                break;
                case 3:
                    semanaporextenso="quarta-feira";                
                break;
                case 4:
                    semanaporextenso="quinta-feira";
                break;
                case 5:
                    semanaporextenso="sexta-feira";
                break;
                case 6:
                    semanaporextenso="sábado";
                break;
                default:
                    semanaporextenso="domingo";
                break;
            }
            Console.WriteLine($"Lages, {data.Day} de {mesporextenso} de {data.Year}. Hoje é {semanaporextenso} as {data.ToLongTimeString()}");
        }
    }
}
