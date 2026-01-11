namespace Lists
{
    internal class Room
    {
        internal int x;
        internal int y;
        internal string[] level;

        internal Room(int x, int y, string[] level)
        {
            this.x = x;
            this.y = y;
            this.level = level;
        }

        internal string GetRoomLocationKey()
        {
            return $"{x},{y}";
        }
    }
}
