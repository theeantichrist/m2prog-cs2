using System;
using System.Collections.Generic;
using System.Linq;

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
            List<Mob> mobs = new List<Mob>();

            mobs.Add(new Mob());
            mobs.Add(new Mob());
            mobs.Add(new Mob());

            Random rand = new Random();

            
            for (int i = 0; i < 100; i++)
            {
                foreach (Mob mob in mobs)
                {
                    int randomNumber = rand.Next(0, 100);

                    if (randomNumber < 30)
                    {
                        mob.TakeDamage(1);
                    }
                }
            }

            
            List<Mob> defeated = mobs.Where(mob => mob.isDead).ToList();

            Console.WriteLine("Verslagen mobs:");
            foreach (Mob mob in defeated)
            {
                Console.WriteLine($"HP: {mob.hp}, Dead: {mob.isDead}");
            }
        }
    }}