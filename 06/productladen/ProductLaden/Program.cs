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
        string fileName = "producten.json";

        if (!File.Exists(fileName))
        {
            Console.WriteLine("producten.json niet gevonden!");
            return;
        }

        string text = File.ReadAllText(fileName);

        Product[] producten = JsonSerializer.Deserialize<Product[]>(text);

        foreach (Product product in producten)
        {
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Description);
            Console.WriteLine(product.Price);
            Console.WriteLine();
        }
    }
}
