using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus on kaks mängijat
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb mängija viskasrohkem
            //mängija, kes viskas rohkem on võitja
            //programm kuulutab võitja

            Random rnd = new Random();
            Console.WriteLine("Esimene mängija veetera täringut");
            Console.ReadLine();
            int Number1 = rnd.Next(1, 7);
            Console.WriteLine($"Sinu number on {Number1}");
            Console.WriteLine("Teine mängija veeteta täringut");
            Console.ReadLine();
            int Number2 = rnd.Next(1, 7);
            Console.WriteLine($"Sinu number on {Number2}");

            if (Number1 < Number2)
            {
                Console.WriteLine("Mängija 2 võitis!");
            }
            else if (Number1 > Number2)
            {
                Console.WriteLine("Mängija 1 võitis!");
            }
            else 
            {
                Console.WriteLine("Mängijad jäid viiki");
            }









        }
    }
}
