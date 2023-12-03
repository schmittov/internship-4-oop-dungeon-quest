namespace Library.Domain.Repositories.Monsters
{
    public class Goblin : Monster
    {

        public Goblin(string name, int maxHealthPoints, int healthPoints, int damage, int spawningChance, int experienceWorth)
            : base(name,maxHealthPoints,healthPoints,damage,spawningChance,experienceWorth)
        {

        }
    }
}
