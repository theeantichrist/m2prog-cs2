using System;

namespace Constructors
{
    internal class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoorden;

        internal Quiz(int aantalVragen)
        {
            vragen = new QuizVraag[aantalVragen];
            ingevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];
        }

        internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            vragen[index] = vraag;
        }

        internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            QuizVraag nieuweVraag = new QuizVraag(vraag, antwoord);
            VoegVraagToeOpIndex(index, nieuweVraag);
        }

       
        internal void StelVraag(int index)
        {
            QuizVraag vraag = vragen[index];

            QuizVraagAntwoord quizVraagAntwoord = new QuizVraagAntwoord(vraag);

            Console.WriteLine(vraag.vraag);
            quizVraagAntwoord.gegevenAntwoord = Console.ReadLine() ?? "";

           
            if (quizVraagAntwoord.gegevenAntwoord.Trim().ToLower() == vraag.antwoord.Trim().ToLower())
            {
                quizVraagAntwoord.goed = true;
                Console.WriteLine("Goedzo a neef");
            }
            else
            {
                quizVraagAntwoord.goed = false;
                Console.WriteLine("Fout a neef");
            }

            
            ingevuldeAntwoorden[index] = quizVraagAntwoord;
        }

               internal int BerekenScore()
        {
            int score = 0;

            for (int i = 0; i < ingevuldeAntwoorden.Length; i++)
            {
                if (ingevuldeAntwoorden[i] != null && ingevuldeAntwoorden[i].goed)
                {
                    score++;
                }
            }

            return score;
        }
    }
}
