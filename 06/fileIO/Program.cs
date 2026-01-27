using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {
        Console.WriteLine("FileIo project");
        Console.WriteLine("Current directory: " + Environment.CurrentDirectory);

        if (!File.Exists("quiz.txt"))
        {
            Console.WriteLine("quiz.txt niet gevonden!");
            return;
        }

        string[] lines = File.ReadAllLines("quiz.txt");

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
