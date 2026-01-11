using System;
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        
        Dictionary<string, Room> rooms = new Dictionary<string, Room>();

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        void Run()
        {
            
            Room start = new Room(0, 0, new string[]
            {
                "xxxxx",
                "x...x",
                "x...x",
                "x...x",
                "xxxxx"
            });

            rooms.Add(start.GetRoomLocationKey(), start);

            
            Room room01 = new Room(0, 1, new string[]
            {
                "xxxxx",
                "x...x",
                "xxxxx",
                "x...x",
                "xxxxx"
            });

            Room room11 = new Room(1, 1, new string[]
            {
                "xxxxx",
                "x...x",
                "x.X.x",
                "x...x",
                "xxxxx"
            });

            Room room10 = new Room(1, 0, new string[]
            {
                "xxxxx",
                "xx..x",
                "x...x",
                "x..xx",
                "xxxxx"
            });

            rooms.Add(room01.GetRoomLocationKey(), room01);
            rooms.Add(room11.GetRoomLocationKey(), room11);
            rooms.Add(room10.GetRoomLocationKey(), room10);

            // TESTS
            ShowRoom(0, 0);
            ShowRoom(0, 1);
            ShowRoom(1, 1);
            ShowRoom(1, 0);

           
            ShowRoom(5, 5);
        }

        private void ShowRoom(int x, int y)
        {
            string key = $"{x},{y}";

            if (rooms.ContainsKey(key))
            {
                Room room = rooms[key];

                Console.WriteLine($"You are in room {x},{y}");
                foreach (string r in room.level)
                {
                    Console.WriteLine(r);
                }
            }
            else
            {
                Console.WriteLine("THIS ROOM DOES NOT EXIST");
            }
        }
    }
}
