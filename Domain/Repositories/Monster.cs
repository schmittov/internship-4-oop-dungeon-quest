namespace Library.Domain.Repositories
{
    public class Monster : Character
    {
        public int SpawningChance { get; set; }
        public Monster(string name, int healthPoints, int damage, int spawningChance) : base(name, healthPoints, damage)
        {
            SpawningChance = spawningChance;
        }
    }
}
