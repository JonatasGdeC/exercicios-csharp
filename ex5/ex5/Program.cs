//5) Criar um programa que leia um número que será o limite superior de um intervalo e 
//o incremento. Exibir todos os números naturais no intervalo de 0 até esse número.  
//Suponha que os dois números lidos são maiores que zero. Exemplo: 
//Limite superior: 20
//Incremento: 5
//Saída: 0  5  10  15  20


class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o número de incremento: ");
        int numIncremento = int.Parse(Console.ReadLine());
        while (numIncremento <= 0)
        {
            Console.Write("\nO número de incremento não pode ser menor ou igual a 0\n");
            Console.Write("Digite o número de incremento: ");
            numIncremento = int.Parse(Console.ReadLine());
        }

        Console.Write("Digite o limite superior: ");
        int limite = int.Parse(Console.ReadLine());
        while (limite <= 0)
        {
            Console.Write("\nO Limite não pode ser menor ou igual a 0\n");
            Console.Write("Digite o limite superior: ");
            limite = int.Parse(Console.ReadLine());
        }

        List<int> numeros = new List<int>();
        for (int i = 0; i <= limite; i += numIncremento)
        {
            numeros.Add(i);
        }
        Console.WriteLine("Segue a lista até " + limite + ", incrementando de " + numIncremento + " em " + numIncremento + ":");
        foreach (int i in numeros)
        {
            Console.Write(i + " ");
        }
    }
}