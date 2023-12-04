using Library.Domain.Repositories.Enums;

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

        public override string MakeAttack(int choosenNumberFromTypeOfAttack)
        {
            switch (choosenNumberFromTypeOfAttack)
            {
                case 1:
                    return AttackType.direct.ToString();
                case 2:
                    return AttackType.side.ToString();
                default:
                    return AttackType.counter.ToString();
            }
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
        public static int CheckHealthStatus(int heroHealth,int heroMaxHealth)
        {
            if (heroHealth > heroMaxHealth)
                return heroMaxHealth;
            else
                return heroHealth;
        }
    }
}
