using System;

namespace ForHerhaling
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
            
            double[] prijzen = { 0.99, 5.60, 10.11, 2.49 };
            string[] artikelen = { "snoepje", "luxe broodje", "lunch menu", "koffie" };

            
            Formulier[] formulieren = new Formulier[2];

            
            formulieren[0] = new Formulier
            {
                Sterren = 5,
                Feedback = "prijzig maar lekker"
            };

            formulieren[1] = new Formulier
            {
                Sterren = 3,
                Feedback = "lunch menu was oke"
            };

            
            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine(prijzen[i]);
                Console.WriteLine(artikelen[i]);
            }

            
            foreach (Formulier formulier in formulieren)
            {
                Console.WriteLine(formulier.Feedback);
                Console.WriteLine(formulier.Sterren);
            }
        }
    }
}
