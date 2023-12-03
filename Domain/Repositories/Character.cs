namespace Library.Domain.Repositories
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int MaxHealthPoints { get; set; }
        public int HealthPoints { get; set; }
        public int Damage { get; set; }
    }
}
