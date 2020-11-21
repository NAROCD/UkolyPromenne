using System;

namespace Ukol4
{
    class Program
    {
        static void Main(string[] args)
        {
            float prumerK;
            double vysledekO;
            double vysledekS;

            Console.WriteLine("Zadejte průměr kružnice");
            prumerK = float.Parse(Console.ReadLine());
            vysledekO = 2 * (Math.PI * prumerK);
            vysledekS = Math.PI * Math.Pow(prumerK, 2);            
            Console.WriteLine("Obvod kruznice je: " + vysledekO+ " cm" + " Obsah kruznice je: " +vysledekS+" cm^2 ");
            Console.ReadLine();
        }
    }
}
