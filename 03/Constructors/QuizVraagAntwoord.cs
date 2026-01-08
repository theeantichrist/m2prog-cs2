namespace Constructors
{
    internal class QuizVraagAntwoord
    {
        internal QuizVraag vraag;
        internal string gegevenAntwoord;
        internal bool goed;

        internal QuizVraagAntwoord(QuizVraag vraag)
        {
            this.vraag = vraag;
            gegevenAntwoord = "";
            goed = false;
        }
    }
}
