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
    Quiz quiz = new Quiz(10);

    
    quiz.VoegVraagToeOpIndex(0, "Wat is 2 + 2?", "4");
    quiz.VoegVraagToeOpIndex(1, "Hoofdstad van Nederland?", "Amsterdam");
    quiz.VoegVraagToeOpIndex(2, "Kleur van de lucht?", "Blauw");
    quiz.VoegVraagToeOpIndex(3, "5 + 5?", "10");
    quiz.VoegVraagToeOpIndex(4, "Dag na maandag?", "Dinsdag");

    
    QuizVraag v5 = new QuizVraag("1 + 1?", "2");
    QuizVraag v6 = new QuizVraag("Hoofdstad van Frankrijk?", "Parijs");
    QuizVraag v7 = new QuizVraag("Kleur van gras?", "Groen");
    QuizVraag v8 = new QuizVraag("10 / 2?", "5");
    QuizVraag v9 = new QuizVraag("Zon komt op in het?", "Oosten");

    quiz.VoegVraagToeOpIndex(5, v5);
    quiz.VoegVraagToeOpIndex(6, v6);
    quiz.VoegVraagToeOpIndex(7, v7);
    quiz.VoegVraagToeOpIndex(8, v8);
    quiz.VoegVraagToeOpIndex(9, v9);

    
    Console.WriteLine(quiz.vragen[0].vraag);
    Console.WriteLine(quiz.vragen[9].vraag);
}
    }
}