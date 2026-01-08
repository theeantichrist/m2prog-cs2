using System;

namespace rijLeraar
{
    internal class RijLeraar
    {
        internal string naam;
        internal int leeftijd;
        internal bool zzp;

        internal void ToonInfo()
        {
            Console.WriteLine($"Naam: {naam}, Leeftijd: {leeftijd}, ZZP: {zzp}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        void Run()
        {
            RijLeraar rijLeraar1 = new RijLeraar()
            {
                naam = "John",
                leeftijd = 30,
                zzp = false
            };

            rijLeraar1.ToonInfo(); // optioneel maar logisch
        }
    }
}
