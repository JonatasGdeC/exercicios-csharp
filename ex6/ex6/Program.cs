//1) Ler o nome de um produto, o preço e a quantidade comprada. Escreva o nome do 
//produto comprado e o valor total a ser pago, considerando que são oferecidos descontos 
//pelo número de unidades compradas, segundo a tabela abaixo: 
//a) Até 10 unidades: valor total 
//b) De 11 a 20 unidades: 10 % de desconto
//c) De 21 a 50 unidades: 20 % de desconto
//d) Acima de 50 unidades: 25 % de desconto
//Calcular o valor total a ser pago através de uma função que retorna valor. 

class Program { 
    public static void Main(String[] args)
    {
        try
        {
            Console.Write("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Digite o preco unitário: R$ ");
            double preco = Double.Parse(Console.ReadLine());
            while (preco <= 0)
            {
                Console.WriteLine("\nDigite um preço válido maior e diferente de 0!\n");
                Console.Write("Digite o preço uniário: R$ ");
                preco = Double.Parse(Console.ReadLine());
            }

            Console.Write("Digite quantas unidades foram compradas: ");
            int qtdComprada = int.Parse(Console.ReadLine());
            while (qtdComprada <= 0)
            {
                Console.WriteLine("\nA quantidade comprada não pode ser menor ou igual a 0!\n");
                Console.Write("Digite quantas unidades foram compradas: ");
                qtdComprada = int.Parse(Console.ReadLine());
            }

            Console.Write("\nAo comprar " + qtdComprada + " unidade(s) de " + nomeProduto + ", o valor a pagar é de R$ " + CalculaPreco(preco, qtdComprada) + "\n");
        } catch (Exception ex)
        {
            Console.WriteLine("\nNão adicione letras aos campos de 'Preço' e 'Unidade'!");
        }
    }

    public static double CalculaPreco(double precoUnid, int qtd)
    {
        double preco = precoUnid * qtd;
        double descontoPorcentagem;

        if(qtd <= 10)
        {
            descontoPorcentagem = 0;
        } else if (qtd >= 11 && qtd <= 20) {
            descontoPorcentagem = 0.1;
        } else if(qtd >= 21 && qtd <= 50)
        {
            descontoPorcentagem = 0.2;
        } else
        {
            descontoPorcentagem = 0.25;
        }

        double desconto = preco * descontoPorcentagem;
        double precoFinal = preco - desconto;


        return precoFinal;
    }
}
