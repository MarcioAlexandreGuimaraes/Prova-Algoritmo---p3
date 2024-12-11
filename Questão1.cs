using System;

class Program
{
    static void Main()
    {
        double nota1 = double.Parse(Console.ReadLine());
        double nota2 = double.Parse(Console.ReadLine());
        double nota3 = double.Parse(Console.ReadLine());
        double nota4 = double.Parse(Console.ReadLine());

        double media = (nota1 * 2 + nota2 * 3 + nota3 * 4 + nota4 * 1) / 10;

        if (media >= 7.0)
        {
            Console.WriteLine("Aprovado");
        }
        else if (media >= 5.0 && media < 7.0)
        {
            Console.WriteLine("Exame");
            double exame = double.Parse(Console.ReadLine());
            double mediaFinal = (media + exame) / 2;
            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
        else
        {
            Console.WriteLine("Reprovado");
        }

        Console.WriteLine("Media Final");
    }
}