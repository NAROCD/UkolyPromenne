using System;

namespace Ukol5
{
    class Program
    {
        static void Main(string[] args)
        {
            float ujetekm;
            float palivoL;
            Console.WriteLine("Zadejte ujeté kilometry: ");
            ujetekm = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte spotrebované palivo: ");
            palivoL = float.Parse(Console.ReadLine());

            Console.WriteLine("Průměrná spotřeba byla: "+ (palivoL/ujetekm)*100 + " L" );
            Console.ReadLine();
        }
    }
}
