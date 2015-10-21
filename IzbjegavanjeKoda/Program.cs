using System;

namespace IzbjegavanjeKoda
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.MetodaKojuPozivamo();
            Console.WriteLine();
            Console.ReadKey();
        }

        void MetodaKojuPozivamo()
        {
            Console.WriteLine("MetodaKojuPozivamo()");
            if (Environment.Version >= new Version(3, 5))
                MetodaKojuŽelimoIzbjeći();
        }

        void MetodaKojuŽelimoIzbjeći()
        {
            Console.WriteLine("MetodaKojuŽelimoIzbjeći()");
        }
    }
}
