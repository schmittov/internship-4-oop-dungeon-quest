namespace Library.Domain.Repositories.Monsters
{
    public class Brute : Monster
    {
        public int SpecialAttack {  get; set; }    
        public Brute(string name, int maxHealthPoints, int healthPoints, int damage, int spawningChance, int experienceWorth,int specialAttack)
            : base(name, maxHealthPoints, healthPoints, damage, spawningChance, experienceWorth)
        {
            SpecialAttack = specialAttack;
        }
    }
}
