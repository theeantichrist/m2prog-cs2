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
            VoegVraagToeOpIndex(index, nieuweVraag); // LET OP: andere functie gebruiken
        }
    }
}
