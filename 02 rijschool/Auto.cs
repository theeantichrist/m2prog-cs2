namespace Auto
{
    internal class Auto
    {
        public string merk;
        public string kenteken;
        public bool automaat;
        public int kilometerStand;

        public void ToonInfo()
        {
            Console.WriteLine($"Merk: {merk}, Kenteken: {kenteken}, Automaat: {automaat}, Kilometerstand: {kilometerStand}");
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
            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerStand = 20567,
                merk = "Volkswagen"
            };

            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 65739,
                merk = "Volvo"
            };

            auto1.ToonInfo();
            auto2.ToonInfo();
        }
    }
}
