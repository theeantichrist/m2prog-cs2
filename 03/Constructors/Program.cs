using System;

namespace Constructors
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
            QuizVraag quizVraag = new QuizVraag(
                "hier komt de vraag",
                "hier komt het antwoord"
            );

            Console.WriteLine(quizVraag.vraag);
            Console.WriteLine(quizVraag.antwoord);
        }
    }
}
