namespace Rijschool
{
    internal class LesUur
    {
        internal Auto auto;
        internal RijLeraar rijLeraar;
        internal int tijd;

        internal void ToonInfo()
        {
            Console.WriteLine($"LesUur Tijd: {tijd}");
            auto.ToonInfo();
            rijLeraar.ToonInfo();
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
            Auto autol = new Auto()
            {
                merk = "Volkswagen",
                kenteken = "AA824H",
                automaat = true,
                kilometerStand = 20567
            };

            RijLeraar rijLeraar = new RijLeraar()
            {
                naam = "John",
                leeftijd = 30,
                zzp = false
            };

            LesUur lesUur = new LesUur()
            {
                auto = autol,
                rijLeraar = rijLeraar,
                tijd = 1130
            };

            lesUur.ToonInfo();
        }
    }

    internal class Auto
    {
        internal string merk;
        internal string kenteken;
        internal bool automaat;
        internal int kilometerStand;

        internal void ToonInfo()
        {
            Console.WriteLine($"Auto: {merk}, Kenteken: {kenteken}, Automaat: {automaat}, Kilometerstand: {kilometerStand}");
        }
    }

    internal class RijLeraar
    {
        internal string naam;
        internal int leeftijd;
        internal bool zzp;

        internal void ToonInfo()
        {
            Console.WriteLine($"RijLeraar: {naam}, Leeftijd: {leeftijd}, ZZP: {zzp}");
        }
    }
}
