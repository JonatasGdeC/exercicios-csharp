//6) Escreva um programa para ler um valor e escrever a soma da sua tabuada de 1 até 10 
//Ex: 
//Digite Numero 
//5 
//Soma da Tabuada = 275

class Program {
    public static void Main(String[] args) {
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());
        while (num <= 0) {
            Console.Write("\nDigite um número maior e diferente de 0!\n");
            Console.Write("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());
        }

        Console.Write("\nA soma dos resultados da tabuada do numero " + num + " é: " + SomaTabuada(num) + "\n");
    }

    public static int SomaTabuada(int num)
    {
        int somaTudo = 0;

        for(int i = 0; i<=10; i++)
        {
            somaTudo += (num * i);
        }

        return somaTudo;
    }
}
