using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {
        
        File.WriteAllText("mijntekst.txt", "Ik ben Ilham");

        
        string[] regels =
        {
            "Zachte regen valt",
            "De nacht ademt stilte in",
            "Maanlicht op het pad"
        };

        File.WriteAllLines("mijnregels.txt", regels);

        
        FavoriteGame[] favoriteGames =
        {
            new FavoriteGame { Name = "Super Metroid", Platform = "SNES" },
            new FavoriteGame { Name = "Demon's Souls", Platform = "PS5" },
            new FavoriteGame { Name = "Zelda: A Link to the Past", Platform = "SNES" }
        };

        string json = JsonSerializer.Serialize(favoriteGames, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText("games.json", json);

        Console.WriteLine("Bestanden zijn geschreven ✔");
    }
}
