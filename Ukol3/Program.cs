using System;

namespace Ukol3
{
    class Program
    {
        static void Main(string[] args)
        {
            int mxint = int.MaxValue;
            Console.WriteLine("Max hodnota int je: " + mxint);
            mxint++;
            Console.WriteLine("Toto je hodnota int++: " + mxint);


            uint mxuint = uint.MaxValue;
            Console.WriteLine("Max hodnota int je: " + mxuint);
            mxuint++;
            Console.WriteLine("Toto je hodnota uint++: " + mxuint);
            Console.ReadLine();
        }
    }
}
