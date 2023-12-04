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

        public override void MakeAttack()
        {
            throw new NotImplementedException();
        }
        public static (int,int,bool) GetExperienceAndLevelUp(int monsterExperienceWorth,int heroCurrentExperience)
        {
            if (heroCurrentExperience + monsterExperienceWorth >= 100)
            {
                
                return (heroCurrentExperience+monsterExperienceWorth-100,1,true);
            }
            else
            {
                return (monsterExperienceWorth,0,false);
            }
        }
    }
}
