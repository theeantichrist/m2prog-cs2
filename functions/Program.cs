namespace functions;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();  
    }

    public void Run()
    {
        Console.WriteLine("Hopelijk werkt de functie");

        Vraag1();
        Vraag2();
        Vraag3();
        Vraag4();
        Vraag5();
        Vraag6();
    }

    internal void Vraag1()
    {
        Console.WriteLine("How long do you think you'd survive a zombie apocalypse?");
        string antwoord = Console.ReadLine() ?? "";
        Console.WriteLine("You think you'd survive for " + antwoord + " days.");
    }

    internal void Vraag2()
    {
        Console.WriteLine("What would you do if you won a million dollars?");
        string antwoord = Console.ReadLine() ?? "";
        Console.WriteLine("Interesting choice! With a million dollars, you'd: " + antwoord);
    }

    internal void Vraag3()
    {
        Console.WriteLine("Has someone ever caught you dancing in front of the mirror?");
        string antwoord = Console.ReadLine() ?? "";
        Console.WriteLine("Haha! So your answer is: " + antwoord);
    }

    internal void Vraag4()
    {
        Console.WriteLine("Why do round pizzas come in square boxes?");
        string antwoord = Console.ReadLine() ?? "";
        Console.WriteLine("That's actually a good point... You said: " + antwoord);
    }

    internal void Vraag5()
    {
        Console.WriteLine("Which species would be the rudest if all animals could talk?");
        string antwoord = Console.ReadLine() ?? "";
        Console.WriteLine("You think the rudest species would be: " + antwoord);
    }

    internal void Vraag6()
    {
        Console.WriteLine("What is the worst game you played but still liked?");
        string antwoord = Console.ReadLine() ?? "";
        Console.WriteLine("So the worst-but-fun game was: " + antwoord);
    }
}
