using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        void Run()
        {
            string[] characters =
            {
                "Pac-Man",
                "Samus",
                "Crash Bandicoot",
                "Spyro the Dragon",
                "Donkey Kong",
                "Mario",
                "Luigi",
                "Astro",
                "Solid Snake",
                "Master Chief",
                "Kratos",
                "Sonic the Hedgehog",
                "Link"
            };

            List<string> characterList = new List<string>();

            foreach (string character in characters)
            {
                characterList.Add(character);
            }

            foreach (string character in characterList)
            {
                Console.WriteLine(character);
            }
        }
    }
}
