using System;

class Program
{
    static void Main()
    {
        int diaInicio = int.Parse(Console.ReadLine());
        int mesInicio = int.Parse(Console.ReadLine());
        string inicioEvento = Console.ReadLine();
        string fimEvento = Console.ReadLine();

        DateTime inicio = DateTime.Parse(diaInicio + "/" + mesInicio + "/" + "2024 " + inicioEvento);
        DateTime fim = DateTime.Parse(diaInicio + "/" + mesInicio + "/" + "2024 " + fimEvento);

        TimeSpan duracao = fim - inicio;
        Console.WriteLine(duracao);
    }
}