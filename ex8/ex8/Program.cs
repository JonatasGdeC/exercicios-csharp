//3) Dados três valores X, Y e Z, verificar se eles podem ser os comprimentos dos lados de 
//um triângulo , através de uma função que retorne valor, e, se forem verificar se é um 
//triângulo equilátero, isósceles ou escalenos. Se eles não formarem um triângulo, escrever 
//a mensagem. Considere as seguintes propriedades: 
//• O comprimento de cada lado em um triângulo é menor que a soma dos outros dois 
//lados; 
//• Equiláteros: tem os comprimentos dos três lados iguais; 
//• Isósceles: tem os comprimentos de dois lados iguais; 
//• escaleno: tem os comprimentos dos três lados diferentes.


class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite o valor de algum lado do triângulo: ");
            double lado1 = double.Parse(Console.ReadLine());
            while (lado1 <= 0)
            {
                Console.Write("\nO triângulo não pode ter um lado menor ou igual a 0...\n");
                Console.Write("\nDigite o valor de algum lado do triângulo: ");
                lado1 = double.Parse(Console.ReadLine());
            }

            Console.Write("Digite o valor de outro lado do triângulo: ");
            double lado2 = double.Parse(Console.ReadLine());
            while (lado2 <= 0)
            {
                Console.Write("\nO triângulo não pode ter um lado menor ou igual a 0...\n");
                Console.Write("\nDigite o valor de outro lado do triângulo: ");
                lado2 = double.Parse(Console.ReadLine());
            }

            Console.Write("Digite o valor do último lado do triângulo: ");
            double lado3 = double.Parse(Console.ReadLine());
            while (lado3 <= 0)
            {
                Console.Write("\nO triângulo não pode ter um lado menor ou igual a 0...\n");
                Console.Write("\nDigite o valor do último lado do triângulo: ");
                lado3 = double.Parse(Console.ReadLine());
            }


            if (ConfirmaTriangulo(lado1, lado2, lado3))
            {
                Console.Write("\nO objeto é um triângulo do tipo: " + TipoTriangulo(lado1,lado2,lado3) +".\n");
            }
            else
            {
                Console.Write("\nO objeto não é um triângulo!\n");
            }
        } catch (Exception ex)
        {
            Console.WriteLine("\nDigite apenas números!\n");
        }
        
    }

    public static bool ConfirmaTriangulo(double a, double b, double c)
    {
        bool result = true;

        double soma1 = a + b;
        double soma2 = a + c;
        double soma3 = b + c;

        if(a > soma3 || b > soma2 || c > soma1) { 
            result = false;
        }


        return result;
    }

    public static string TipoTriangulo(double a, double b, double c)
    {
        string result = "";

        if(a == b && a == c && b == c)
        {
            result = "Equiláteros";
        } else if (a == b || a == c || b == c)
        {
            result = "Isósceles";
        } else
        {
            result = "Escaleno";
        }

        return result;
    }
}