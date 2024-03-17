//4) Um programa que calcule a média de uma aluno nos moldes da Fatec MAUÁ. 

class Program { 
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite sua nota na P1: ");
            double p1 = double.Parse(Console.ReadLine());
            while (p1 < 0 || p1 > 10)
            {
                Console.WriteLine("\nAs notas vão de 0 a 10!\n");
                Console.Write("Digite sua nota na P1: ");
                p1 = double.Parse(Console.ReadLine());
            }

            Console.Write("Digite sua nota na P2: ");
            double p2 = double.Parse(Console.ReadLine());
            while (p2 < 0 || p2 > 10)
            {
                Console.WriteLine("\nAs notas vão de 0 a 10!\n");
                Console.Write("Digite sua nota na P2: ");
                p2 = double.Parse(Console.ReadLine());
            }

            Console.Write("Digite sua nota nos trabalhos: ");
            double trabalhos = double.Parse(Console.ReadLine());
            while (trabalhos < 0 || trabalhos > 10)
            {
                Console.WriteLine("\nAs notas vão de 0 a 10!\n");
                Console.Write("Digite sua nota nos trabalhos: ");
                trabalhos = double.Parse(Console.ReadLine());
            }

            double media = (p1 + p2 + trabalhos) / 3;

            if (media >= 7)
            {
                Console.Write("\nParabéns! Você concluiu essa matéria!\n");
            }
            else
            {
                Console.Write("Digite sua nota na P3: ");
                double p3 = double.Parse(Console.ReadLine());
                while (p3 < 0 || p3 > 10)
                {
                    Console.WriteLine("\nAs notas vão de 0 a 10!\n");
                    Console.Write("Digite sua nota na P2: ");
                    p3 = double.Parse(Console.ReadLine());
                }

                double mediaFinal = (media + 3) / 4;

                if (mediaFinal >= 7)
                {
                    Console.Write("\nParabéns! Você concluiu essa matéria!\n");
                }
                else
                {
                    Console.Write("\nIh rapaz... Infelizmente você não consegui concluir essa matéria!\n");
                }
            }
        } catch (Exception e)
        {
            Console.Write("\nNão digite letras!\nAs notas na FATEC são atribuidas de 0 a 10!\n");
        }
       
    }
}
