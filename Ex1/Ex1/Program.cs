//1) Um programa capaz de imprimir todos os números pares em um intervalo de 
//números informador pelo usuário;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro qualquer: ");
        int num1Digitado = int.Parse(Console.ReadLine());
        Console.Write("Digite outro número inteiro qualquer: ");
        int num2Digitado = int.Parse(Console.ReadLine());

        int num1, num2;

        if (num1Digitado < num2Digitado)
        {
            num1 = num1Digitado;
            num2 = num2Digitado;
        } else
        {
            num2 = num1Digitado;
            num1 = num2Digitado;
        }

        List<int> numeros = new List<int>();   

        for(int i = 0; i <= num2; i++)
        {
            if(i % 2 == 0)
            {
                numeros.Add(i);
            }
        }

        Console.WriteLine("Os números pares de " + num1 + " a " + num2 + " são: ");
        foreach (int numeroPar in numeros)
        {
            Console.Write(numeroPar + " ");
        }
    }
}