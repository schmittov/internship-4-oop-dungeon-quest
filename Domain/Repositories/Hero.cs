namespace Library.Domain.Repositories
{
    public class Hero : Character
    {
        public int Experience { get; set; }
        public Hero(string name, int healthPoints, int damage,int experience) : base(name, healthPoints, damage)
        {
            Experience = experience;
        }
    }
}
