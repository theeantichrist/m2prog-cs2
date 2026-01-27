using System;
using System.IO;

class Program
{
   
    static string saveFile = "welkomState.txt";

    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {
        string welkomsTekst = "hello world";

       
        if (File.Exists(saveFile))
        {
            welkomsTekst = File.ReadAllText(saveFile);
        }

       
        while (true)
        {
            Console.WriteLine(welkomsTekst);
            Console.WriteLine("Enter a text, then press enter");

            string input = Console.ReadLine() ?? "";

            
            if (input.Length > 0)
            {
                welkomsTekst = input;
                File.WriteAllText(saveFile, welkomsTekst);
            }
        }
    }
}
