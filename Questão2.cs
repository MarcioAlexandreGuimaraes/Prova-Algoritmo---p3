using System;

class Program
{
    static void Main()
    {
        int diaInicio = int.Parse(Console.ReadLine());
        int mesInicio = 4; 
        string inicioEvento = Console.ReadLine();
        string fimEvento = Console.ReadLine();

        DateTime inicio = DateTime.Parse($"{mesInicio}/{diaInicio}/2024 {inicioEvento}");
        DateTime fim = DateTime.Parse($"{mesInicio}/{diaInicio}/2024 {fimEvento}");

        if (fim < inicio)
        {
            fim = fim.AddMonths(1);
        }

    
