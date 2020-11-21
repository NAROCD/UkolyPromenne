using System;

namespace Ukol2
{
    class Program
    {
        static void Main(string[] args)
        {
            float cislo1;
            float cislo2;
            float vysledek;
            Console.WriteLine("Zadejte první hodnotu: ");
            cislo1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhou hodnotu: ");
            cislo2 = float.Parse(Console.ReadLine());
            vysledek = cislo1 / cislo2;
            Console.WriteLine(vysledek);
            Console.ReadLine();
        }
    }
} 