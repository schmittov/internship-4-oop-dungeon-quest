namespace Library.Domain.Repositories.Monsters
{
    public class Monster : Character
    {
        public int SpawningChance { get; set; }
        public int ExperienceWorth { get; set; }

        public Monster(string name, int maxHealthPoints, int healthPoints, int damage,int spawningChance,int experienceWorth)
        {
            Name = name;
            MaxHealthPoints = maxHealthPoints;
            HealthPoints = healthPoints;     
            Damage = damage;
            SpawningChance = spawningChance;
            ExperienceWorth = experienceWorth;
        }
    }
}
