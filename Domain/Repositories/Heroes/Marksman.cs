namespace Library.Domain.Repositories.Heroes
{
  
    public class Marksman : Hero
    {
        public int StunChance { get; set; }
        public int CriticalChance { get; set; }
        public Marksman(string name, int maxHealthPoints, int healthPoints, int damage, int level, int experience,int stunChance,int criticalChance) 
            :base(name, maxHealthPoints, healthPoints, damage, level, experience)
        {

        } 
    }
}
