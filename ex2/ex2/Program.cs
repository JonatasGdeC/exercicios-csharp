//2) Um programa que imprima até o “n” termo a seqüência de Fibonacci.   Série: 
//1,1,2,3,5,8,13,21....... 
//Por exemplo, imprimir até o 6º termo:  1, 1, 2, 3, 5, 8

using System;

class Program { 
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite o termo desejado da sequência de Fibonacci: ");
            int termo = int.Parse(Console.ReadLine());

            int termo1 = 0;
            int termo2 = 1;
            int termoAtual;
            List<int> numeros = new List<int>();

            for (int i = 2; i <= (termo + 1); i++)
            {
                if (i == 3)
                {
                    termoAtual = termo2;
                }
                else
                {
                    termoAtual = termo1 + termo2;
                }
                numeros.Add(termoAtual);
                termo1 = termo2;
                termo2 = termoAtual;
            }

            Console.WriteLine("Imprimindo até o termo " + termo + ":");
            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }
        } catch (Exception e)
        {
            Console.WriteLine("Erro!\nDigite apenas números");
        }
        
    }
}
