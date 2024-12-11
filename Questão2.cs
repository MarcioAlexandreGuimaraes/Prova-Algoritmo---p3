using System;

class Program
{
    static void Main()
    {
        string classe = Console.ReadLine();
        string tipo = Console.ReadLine();
        string alimentacao = Console.ReadLine();

        if (classe == "vertebrado")
        {
            if (tipo == "ave")
            {
                if (alimentacao == "carnivoro")
                    Console.WriteLine("Aguia");
            }
            else if (tipo == "mamifero")
            {
                if (alimentacao == "onivoro" || alimentacao == "herbivoro")
                    Console.WriteLine("Pomba");
            }
        }
        else if (classe == "invertebrado")
        {
            if (tipo == "inseto")
            {
                if (alimentacao == "hematofago")
                    Console.WriteLine("Pulga");
                else if (alimentacao == "herbivoro")
                    Console.WriteLine("Lagarta");
            }
            else if (tipo == "anelideo")
            {
                if (alimentacao == "hematofago")
                    Console.WriteLine("Sanguessuga");
                else if (a


