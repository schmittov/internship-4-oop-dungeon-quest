namespace Library.Domain.Repositories.Monsters
{
    public class Witch : Monster
    {

        public Witch(string name, int maxHealthPoints, int healthPoints, int damage, int spawningChance, int experienceWorth)
            : base(name, maxHealthPoints, healthPoints, damage, spawningChance, experienceWorth)
        {

        }

    }
}
