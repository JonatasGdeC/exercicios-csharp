//Teemo não está muito animado com a véspera de ano novo, mas ele tem que comemorar com seus amigos de qualquer maneira.

//Ele tem uma grande paixão por programação e quer ser produtivo até meia-noite. Ele quer saber quantos minutos lhe restam para trabalhar em seu novo projeto.
//Ele não quer ficar olhando o relógio o tempo todo, então pensou em uma função que lhe retorna o número de minutos.

//Can you write him a function, so he can stay productive?

//A função minutesToMidnight(d)terá um objeto de data como parâmetro. Retorne o número de minutos no seguinte formato:

//"x minute(s)"

//Você sempre obterá um objeto de data de hoje com um carimbo de data/hora aleatório.
//Você tem que arredondar o número de minutos.
//Milissegundos não importam!


//Some examples:

//10.00 am => "840 minutes"
//23.59 pm => "1 minute"

namespace MinuteCount
{
    public class Minute
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(countMinutes(DateTime.Now.Date.AddHours(12)));
            Console.WriteLine(countMinutes(DateTime.Now.Date.AddHours(23).AddMinutes(59)));
        }

        public static string countMinutes(DateTime d)
        {
            int minutosDia = 1440;
            int minutosPassados = d.Hour * 60 + d.Minute;
            int minutosRestantes = minutosDia - minutosPassados;

            minutosRestantes = (int)Math.Floor((double)minutosRestantes);
            string result = minutosRestantes == 1 ? "1 minute" : minutosRestantes + " minutes";

            return result;
        }
    }
}
