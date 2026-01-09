using System;
using System.Collections.Generic;

namespace Lists
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
            List<double> reviews = new List<double>()
            {
                9.99,
                4.68,
                342.97,
                12.2
            };

            
            foreach (double review in reviews)
            {
                Console.WriteLine(review);
            }

            Console.WriteLine("----");

            
            reviews.Remove(342.97);

            
            reviews.RemoveAt(0);

           
            foreach (double review in reviews)
            {
                Console.WriteLine(review);
            }
        }
    }
}
