//3) Um programa capaz de imprimir todos os números primos em um intervalo de 
//números informado pelo usuário;

class Program
{
    private static void Main(string[] args)
    {
        try
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
            }
            else
            {
                num2 = num1Digitado;
                num1 = num2Digitado;
            }

            List<int> numerosPrimos = new List<int>();
            for (int i = 0; i < num2; i++)
            {
                if (isPrimo(i))
                {
                    numerosPrimos.Add(i);
                }
            }

            Console.WriteLine("\nSegue a lista de números primos de " + num1 + " a " + num2+":\n");
            foreach (int i in numerosPrimos)
            {
                Console.Write(i + " ");
            }
        } catch(Exception ex)
        {
            Console.WriteLine("\nErro!\nDigite apenas números...\n");
        }
        
    }

    public static Boolean isPrimo(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}