using System;

namespace UkolyPromenne
{
    class Program
    {
        static void Main(string[] args)
         {
             string Jmeno;
             Console.WriteLine("Jak se jmenujete?");
             Jmeno = Console.ReadLine();
             Console.WriteLine("Ahoj " + Jmeno);
             Console.ReadLine();
         }
    }
}