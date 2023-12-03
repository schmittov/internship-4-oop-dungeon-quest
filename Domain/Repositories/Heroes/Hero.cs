namespace Library.Domain.Repositories.Heroes
{
    public class Hero : Character
    {
        public int Level { get; set; }
        public int Experience { get; set; }
        public Hero(string name, int maxHealthPoints,int healthPoints, int damage,int level, int experience)
        {
            Name = name;
            MaxHealthPoints = maxHealthPoints;
            HealthPoints = healthPoints;
            Experience = experience;
            Damage = damage;
            Level = level;
        }
    }
}
