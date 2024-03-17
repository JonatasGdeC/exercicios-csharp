///2) Ler número da conta do cliente, saldo, débito e crédito. Após, calcular e escrever o 
//saldo atual(saldo atual = saldo - débito + crédito), através de uma função que retorne 
//valor, também testar se saldo atual for maior ou igual a zero escrever a mensagem 'Saldo 
//Positivo', senão escrever a mensagem 'Saldo Negativo'. 


class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite o número de sua conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Digite seu saldo: R$ ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de crédito a pagar: R$ ");
            double credito = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de débito a pagar: R$ ");
            double debito = double.Parse(Console.ReadLine());

            Console.Write("\nSegundos os dados informados, a conta " + conta + " está com saldo: " + SituacaoAtual(saldo, credito, debito) + "\n");
        } catch (Exception ex)
        {
            Console.WriteLine("\nDigite apenas números!\n");
        }
    }

    public static String SituacaoAtual(double saldo, double credito, double debito)
    {
        double saldoFinal= saldo - (credito + debito);
        string situacaoAtual = "";

        if(saldoFinal >= 0)
        {
            situacaoAtual = "POSITIVO";
        } else
        {
            situacaoAtual = "NEGATIVO";
        }

        return situacaoAtual;
    }
}