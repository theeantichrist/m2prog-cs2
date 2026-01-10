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
            
            List<Pickup> pickups = new List<Pickup>();

            
            for (int i = 0; i < 10; i++)
            {
                Pickup pickup = new Pickup
                {
                    x = i,
                    y = 0
                };

                pickups.Add(pickup);
            }

            
            for (int i = pickups.Count - 1; i >= 0; i--)
            {
                if (pickups[i].x == 4)
                {
                    Console.WriteLine("removed pickup 4");
                    pickups.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine($"pickup {pickups[i].x} is still there");
                }
            }
        }
    }
}
