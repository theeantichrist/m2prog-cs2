using System;

namespace functions
{
    internal class Program
    {
        string[] vragen = new string[]
        {
            "what 1997 N64 video game features James Bond and is named after the 1995 film",
            "what arcade game was called Puckman in Japan"
        };

        internal string GetVraag(int index)
        {
            return vragen[index];
        }

        internal string GetRandomVraag()
        {
            // gebruik Random
            Random rnd = new Random();
            int index = rnd.Next(vragen.Length); // random index
            return GetVraag(index);
        }

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

            string antwoord7 = Vraag7();
            Console.WriteLine("Het antwoord op Vraag7 is: " + antwoord7);

            // Example usage of GetVraag:
            Console.WriteLine("Voorbeeld vraag uit array: " + GetVraag(0));

            // Example usage of GetRandomVraag:
            Console.WriteLine("Random vraag: " + GetRandomVraag());
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

        internal string Vraag7()
        {
            Console.WriteLine("How long do you think you'd survive a zombie apocalypse?");
            string antwoord = Console.ReadLine() ?? "";
            return antwoord;
        }
    }
}
