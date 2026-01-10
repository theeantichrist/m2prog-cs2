namespace Lists
{
    internal class Mob
    {
        internal bool isDead;
        internal int hp = 10;

        internal void TakeDamage(int damage)
        {
            hp -= damage;

            if (hp <= 0)
            {
                isDead = true;
            }
        }
    }
}
