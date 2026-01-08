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

            
            quiz.VoegVraagToeOpIndex(0, "What arcade game was called Puckman in Japan?", "Pac-Man");
            quiz.VoegVraagToeOpIndex(1, "Which video game console released in 2006 pioneered motion controls?", "Nintendo Wii");
            quiz.VoegVraagToeOpIndex(2, "What is thought to be the first video game, created in 1958?", "Pong");
            quiz.VoegVraagToeOpIndex(3, "What 1997 N64 James Bond game is named after a 1995 film?", "GoldenEye");
            quiz.VoegVraagToeOpIndex(4, "Making his debut in 1990's Super Mario World, what green dinosaur sidekick is this?", "Yoshi");

            
            QuizVraag v5 = new QuizVraag("What North Carolina-based company created Fortnite?", "Epic Games");
            QuizVraag v6 = new QuizVraag("What engine owned by Epic Games is used by many developers?", "Unreal Engine");
            QuizVraag v7 = new QuizVraag("Which 2009 sandbox game by Mojang features creepers?", "Minecraft");
            QuizVraag v8 = new QuizVraag("What MMORPG set in Azeroth is known as WoW?", "World of Warcraft");
            QuizVraag v9 = new QuizVraag("What franchise features Master Chief and Cortana?", "Halo");

            quiz.VoegVraagToeOpIndex(5, v5);
            quiz.VoegVraagToeOpIndex(6, v6);
            quiz.VoegVraagToeOpIndex(7, v7);
            quiz.VoegVraagToeOpIndex(8, v8);
            quiz.VoegVraagToeOpIndex(9, v9);

            
            for (int i = 0; i < quiz.vragen.Length; i++)
            {
                quiz.StelVraag(i);
                Console.WriteLine();
            }

            
            int score = quiz.BerekenScore();
            Console.WriteLine($"Score: {score}/{quiz.vragen.Length}");
        }
    }
}
