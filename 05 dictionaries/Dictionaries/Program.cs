using System;
using System.Collections.Generic;

namespace Dictionaries
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
            Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

            personeelOpNummer.Add(382942, "jim");
            personeelOpNummer.Add(789432, "tim");

            
            foreach (KeyValuePair<int, string> item in personeelOpNummer)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
